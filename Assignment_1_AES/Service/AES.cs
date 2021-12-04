using Assignment_1_AES.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_1_AES.Service
{
    public class Aes : IAes
    {
        #region [Const]
        private byte[] _Key;
        private const int _Nb = 4;
        private const int _Ws = 4;
        private const int _BlockSize = 16;
        private static int _CountRound = 11;

        private static byte[] _sbox = {
            0x63, 0x7c, 0x77, 0x7b, 0xf2, 0x6b, 0x6f, 0xc5, 0x30, 0x01, 0x67, 0x2b, 0xfe, 0xd7, 0xab, 0x76,
            0xca, 0x82, 0xc9, 0x7d, 0xfa, 0x59, 0x47, 0xf0, 0xad, 0xd4, 0xa2, 0xaf, 0x9c, 0xa4, 0x72, 0xc0,
            0xb7, 0xfd, 0x93, 0x26, 0x36, 0x3f, 0xf7, 0xcc, 0x34, 0xa5, 0xe5, 0xf1, 0x71, 0xd8, 0x31, 0x15,
            0x04, 0xc7, 0x23, 0xc3, 0x18, 0x96, 0x05, 0x9a, 0x07, 0x12, 0x80, 0xe2, 0xeb, 0x27, 0xb2, 0x75,
            0x09, 0x83, 0x2c, 0x1a, 0x1b, 0x6e, 0x5a, 0xa0, 0x52, 0x3b, 0xd6, 0xb3, 0x29, 0xe3, 0x2f, 0x84,
            0x53, 0xd1, 0x00, 0xed, 0x20, 0xfc, 0xb1, 0x5b, 0x6a, 0xcb, 0xbe, 0x39, 0x4a, 0x4c, 0x58, 0xcf,
            0xd0, 0xef, 0xaa, 0xfb, 0x43, 0x4d, 0x33, 0x85, 0x45, 0xf9, 0x02, 0x7f, 0x50, 0x3c, 0x9f, 0xa8,
            0x51, 0xa3, 0x40, 0x8f, 0x92, 0x9d, 0x38, 0xf5, 0xbc, 0xb6, 0xda, 0x21, 0x10, 0xff, 0xf3, 0xd2,
            0xcd, 0x0c, 0x13, 0xec, 0x5f, 0x97, 0x44, 0x17, 0xc4, 0xa7, 0x7e, 0x3d, 0x64, 0x5d, 0x19, 0x73,
            0x60, 0x81, 0x4f, 0xdc, 0x22, 0x2a, 0x90, 0x88, 0x46, 0xee, 0xb8, 0x14, 0xde, 0x5e, 0x0b, 0xdb,
            0xe0, 0x32, 0x3a, 0x0a, 0x49, 0x06, 0x24, 0x5c, 0xc2, 0xd3, 0xac, 0x62, 0x91, 0x95, 0xe4, 0x79,
            0xe7, 0xc8, 0x37, 0x6d, 0x8d, 0xd5, 0x4e, 0xa9, 0x6c, 0x56, 0xf4, 0xea, 0x65, 0x7a, 0xae, 0x08,
            0xba, 0x78, 0x25, 0x2e, 0x1c, 0xa6, 0xb4, 0xc6, 0xe8, 0xdd, 0x74, 0x1f, 0x4b, 0xbd, 0x8b, 0x8a,
            0x70, 0x3e, 0xb5, 0x66, 0x48, 0x03, 0xf6, 0x0e, 0x61, 0x35, 0x57, 0xb9, 0x86, 0xc1, 0x1d, 0x9e,
            0xe1, 0xf8, 0x98, 0x11, 0x69, 0xd9, 0x8e, 0x94, 0x9b, 0x1e, 0x87, 0xe9, 0xce, 0x55, 0x28, 0xdf,
            0x8c, 0xa1, 0x89, 0x0d, 0xbf, 0xe6, 0x42, 0x68, 0x41, 0x99, 0x2d, 0x0f, 0xb0, 0x54, 0xbb, 0x16
        };

        private static byte[,] _rCon = {
             {0x00, 0x00, 0x00, 0x00},
             {0x01, 0x00, 0x00, 0x00},
             {0x02, 0x00, 0x00, 0x00},
             {0x04, 0x00, 0x00, 0x00},
             {0x08, 0x00, 0x00, 0x00},
             {0x10, 0x00, 0x00, 0x00},
             {0x20, 0x00, 0x00, 0x00},
             {0x40, 0x00, 0x00, 0x00},
             {0x80, 0x00, 0x00, 0x00},
             {0x1b, 0x00, 0x00, 0x00},
             {0x36, 0x00, 0x00, 0x00}
        };

        #endregion [Const]


        #region [c'tors]

        public Aes(byte[] key)
        {
            this._Key = key;
        }

        public Aes(string sKey, int nBits)
        {
            _Key = BuildKey(sKey, nBits);
        }

        private static byte[] BuildKey(string sKey, int nBits)
        {
            if (!(nBits == 128 || nBits == 192 || nBits == 256))
                throw new Exception("standard allows, 128/192/256 bit keys");
            byte[] keyBytes = ASCIIEncoding.UTF8.GetBytes(sKey);
            var nBytes = nBits / 8;
            byte[] key = new byte[nBytes];
            for (int i = 0; i < nBytes; i++)
            {
                if (i >= keyBytes.Length)
                    key[i] = 0;
                else
                    key[i] = keyBytes[i];
            }
            return key;
        }

        #endregion [c'tors]

        #region [Private Methods]

        private byte[] Cipher(byte[] input, byte[,] w)
        {
            int Nk = _Key.Length / _Ws;
            int Nr = Nk + 6;

            byte[,] state = new byte[_Ws, _Nb];
            for (var i = 0; i < (_Ws * _Nb); i++)
                state[i % _Ws, Convert.ToInt32(Math.Floor((double)(i / _Ws)))] = input[i];

            state = AddRoundKey(state, w, 0);

            for (var round = 1; round < Nr; round++)
            {
                state = SubBytes(state);
                state = ShiftRows(state);
                state = MixColumns(state);
                state = AddRoundKey(state, w, round);
            }

            state = SubBytes(state);
            state = ShiftRows(state);
            state = AddRoundKey(state, w, Nr);

            var output = new byte[_Ws * _Nb];
            for (var i = 0; i < _Ws * _Nb; i++)
                output[i] = state[i % _Ws, Convert.ToInt32(Math.Floor((double)(i / _Ws)))];
            return output;
        }

        private byte[,] KeyExpansion(byte[] key)
        {
            int Nk = key.Length / _Ws;
            int Nr = Nk + 6;

            byte[,] w = new byte[(_Nb * (Nr + 1)), _Nb];
            byte[] temp = new byte[_Ws];

            for (int i = 0; i < Nk; i++)
            {
                w[i, 0] = key[_Ws * i];
                w[i, 1] = key[_Ws * i + 1];
                w[i, 2] = key[_Ws * i + 2];
                w[i, 3] = key[_Ws * i + 3];
            }

            for (int i = Nk; i < (_Nb * (Nr + 1)); i++)
            {
                w[i, 0] = 0;
                w[i, 1] = 0;
                w[i, 2] = 0;
                w[i, 3] = 0;
                for (var t = 0; t < _Ws; t++)
                    temp[t] = w[i - 1, t];
                if (i % Nk == 0)
                {
                    temp = SubWord(RotWord(temp));
                    for (var t = 0; t < _Ws; t++)
                        temp[t] ^= _rCon[(i / Nk), t];
                }
                else if (Nk > 6 && i % Nk == _Ws)
                {
                    temp = SubWord(temp);
                }
                for (var t = 0; t < _Ws; t++)
                    w[i, t] = (byte)(w[(i - Nk), t] ^ temp[t]);
            }
            return w;
        }

        private byte[,] KeyExpansion() => KeyExpansion(_Key);

        private static byte[,] AddRoundKey(byte[,] state, byte[,] w, int rnd)
        {
            for (var r = 0; r < _Ws; r++)
                for (var c = 0; c < _Nb; c++)
                    state[r, c] ^= w[rnd * _Ws + c, r];
            return state;
        }

        private byte[] SubWord(byte[] w)
        {
            for (var i = 0; i < _Ws; i++)
                w[i] = _sbox[w[i]];
            return w;
        }

        private byte[] RotWord(byte[] w)
        {
            var tmp = w[0];
            for (var i = 0; i < (_Ws - 1); i++)
                w[i] = w[i + 1];
            w[(_Ws - 1)] = tmp;
            return w;
        }

        private byte[,] SubBytes(byte[,] s)
        {
            for (var r = 0; r < 4; r++)
                for (var c = 0; c < _Nb; c++)
                    s[r, c] = _sbox[s[r, c]];
            return s;
        }

        private byte[,] ShiftRows(byte[,] s)
        {
            byte[] t = new byte[_Ws];
            for (int r = 1; r < _Ws; r++)
            {
                for (int c = 0; c < _Ws; c++)
                    t[c] = s[r, (c + r) % _Nb];
                for (int c = 0; c < _Ws; c++)
                    s[r, c] = t[c];
            }
            return s;
        }

        private byte[,] MixColumns(byte[,] s)
        {
            for (var c = 0; c < _Ws; c++)
            {
                var a = new byte[_Ws];
                var b = new byte[_Ws];
                for (var i = 0; i < _Ws; i++)
                {
                    a[i] = s[i, c];
                    b[i] = (byte)(s[i, c] & 0x80) != 0 ? (byte)((s[i, c] << 1) ^ 0x011b) : (byte)(s[i, c] << 1);
                }
                s[0, c] = (byte)(b[0] ^ a[1] ^ b[1] ^ a[2] ^ a[3]);
                s[1, c] = (byte)(a[0] ^ b[1] ^ a[2] ^ b[2] ^ a[3]);
                s[2, c] = (byte)(a[0] ^ a[1] ^ b[2] ^ a[3] ^ b[3]);
                s[3, c] = (byte)(a[0] ^ b[0] ^ a[1] ^ a[2] ^ b[3]);
            }
            return s;
        }

        #endregion [Private Methods]

        #region [Public Methods]

        public string Encrypt(string plaintext)
        {
            string ciphertext = "";
            try
            {
                byte[] ciphertextBytes = Encrypt(ASCIIEncoding.UTF8.GetBytes(plaintext));
                ciphertext = Convert.ToBase64String(ciphertextBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("While encrypting something went wrong! \n" + ex.Message);
                //throw;
            }
            return ciphertext;
        }

        public byte[] Encrypt(byte[] plaintext)
        {
            List<byte> ciphertext = new List<byte>();
            try
            {
                byte[,] eKey = KeyExpansion();
                byte[] key = Cipher(_Key, eKey);
                key = key.Concat(key.Slice(0, _Key.Length - _BlockSize)).ToArray();
                byte[] counterBlock = new byte[_BlockSize];
                long nonce = (DateTime.UtcNow.Ticks - 621355968000000000) / 10000;  // timestamp: difference with  1-Jan-1970
                long nonceMs = nonce % 1000;
                double nonceSec = Math.Floor((double)(nonce / 1000));
                Random random = new Random();
                long nonceRnd = Convert.ToInt64(Math.Floor(random.NextDouble() * (double)0xffff));

                for (var i = 0; i < 2; i++)
                    counterBlock[i] = (byte)((byte)(((UInt64)nonceMs) >> i * 8) & 0xff);
                for (var i = 0; i < 2; i++)
                    counterBlock[i + 2] = (byte)((byte)(((UInt64)nonceRnd) >> i * 8) & 0xff);
                for (var i = 0; i < 4; i++)
                    counterBlock[i + 4] = (byte)((byte)(((UInt64)nonceSec) >> i * 8) & 0xff);

                for (var i = 0; i < 8; i++)
                    ciphertext.Add(counterBlock[i]);

                var keySchedule = KeyExpansion(key);

                int blockCount = Convert.ToInt32(Math.Ceiling((double)plaintext.Length / _BlockSize));
                byte[][] cipherarr = new byte[blockCount][];

                for (var b = 0; b < blockCount; b++)
                {
                    for (var c = 0; c < 4; c++)
                        counterBlock[15 - c] = (byte)((byte)(((UInt32)b) >> c * 8) & 0xff);
                    for (var c = 0; c < 4; c++)
                        counterBlock[15 - c - 4] = (byte)(((UInt32)(b / (double)0x100000000)) >> c * 8);

                    byte[] cipherCntr = Cipher(counterBlock, keySchedule);  // -- encrypt counter block --

                    int blockLength = b < blockCount - 1 ? _BlockSize : (plaintext.Length - 1) % _BlockSize + 1;
                    byte[] cipherChar = new byte[blockLength];

                    for (var i = 0; i < blockLength; i++)
                        cipherChar[i] = (byte)(cipherCntr[i] ^ plaintext[b * _BlockSize + i]);
                    cipherarr[b] = cipherChar;
                    ciphertext.AddRange(cipherChar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("While encrypting something went wrong! \n" + ex.Message);
            }
            return ciphertext.ToArray();
        }

        public string Decrypt(string ciphertext)
        {
            string plaintext = "";
            try
            {
                byte[] plaintextBytes = Decrypt(Convert.FromBase64String(ciphertext));
                plaintext = ASCIIEncoding.UTF8.GetString(plaintextBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("MIM, you have modified the cipher text unsucessfully! \n" + ex.Message);
                //throw new Exception(ex.Message);
            }
            return plaintext;
        }

        public byte[] Decrypt(byte[] ciphertext)
        {
            List<byte> plaintext = new List<byte>();
            try
            {
                byte[,] eKey = KeyExpansion();
                byte[] key = Cipher(_Key, eKey);
                key = key.Concat(key.Slice(0, _Key.Length - _BlockSize)).ToArray();
                byte[] counterBlock = new byte[_BlockSize];
                ciphertext.Slice(0, 8).CopyTo(counterBlock, 0);
                var keySchedule = KeyExpansion(key);
                int nBlocks = Convert.ToInt32(Math.Ceiling((double)(ciphertext.Length - 8) / _BlockSize));
                byte[][] ct = new byte[nBlocks][];
                for (var b = 0; b < nBlocks; b++)
                {
                    int start = 8 + b * _BlockSize;
                    int end = start + _BlockSize;
                    if (end > ciphertext.Length)
                        end = ciphertext.Length;
                    ct[b] = ciphertext.Slice(start, end);
                }

                byte[][] plaintxtarr = new byte[nBlocks][];

                for (int b = 0; b < nBlocks; b++)
                {
                    for (int c = 0; c < 4; c++)
                        counterBlock[15 - c] = (byte)((byte)(((UInt32)b) >> c * 8) & 0xff);
                    for (int c = 0; c < 4; c++)
                    {
                        counterBlock[15 - c - 4] = (byte)((byte)(((UInt32)(((b + 1) / (double)0x100000000) - 1)) >> c * 8) & 0xff);
                    }
                    byte[] cipherCntr = Cipher(counterBlock, keySchedule);
                    byte[] plaintxtByte = new byte[ct[b].Length];
                    for (int i = 0; i < ct[b].Length; i++)
                        plaintxtByte[i] = (byte)(cipherCntr[i] ^ ct[b][i]);
                    plaintxtarr[b] = plaintxtByte;
                    plaintext.AddRange(plaintxtByte);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MIM, you have modified the cipher text unsucessfully! \n" + ex.Message);
                //throw new Exception(ex.Message);
            }
            return plaintext.ToArray();
        }

        #endregion [Public Methods]
    }
}
