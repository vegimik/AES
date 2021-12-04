using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_AES.Service
{
    public interface IAes
    {

        void Cipher(byte[] input, byte[] output);
        void InvCipher(byte[] input, byte[] output);


    }
}
