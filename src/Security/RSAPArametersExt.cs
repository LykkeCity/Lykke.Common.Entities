using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Lykke.Common.Entities.Security
{
    public static class RSAParametersExt
    {
        public static string GetPublicKey(this RSAParameters parameters)
        {

            var result = new List<byte>();
            result.AddRange(new byte[] {0x00, 0x00, 0x00, 0x07 }); //7 byte algorithm identifier
            result.AddRange(new byte[] { 0x73, 0x73, 0x68, 0x2d, 0x72, 0x73, 0x61 }); //"ssh-rsa"
            result.AddRange(new byte[] { 0x00, 0x00, 0x00, (byte)parameters.Exponent.Length }); //3 byte exponent; 
            result.AddRange(parameters.Exponent);
            result.AddRange(new byte[] { 0x00, 0x00, 0x00, (byte)parameters.Modulus.Length }); //128 byte modulus
            result.AddRange(parameters.Modulus);

            return Convert.ToBase64String(result.ToArray());
        }

        public static string GetPrivateKey(this RSAParameters parameters)
        {
            var result = new List<byte>();
            result.AddRange(new byte[] { 0x00, 0x00, 0x00, 0x07 }); //7 byte algorithm identifier
            result.AddRange(new byte[] { 0x73, 0x73, 0x68, 0x2d, 0x72, 0x73, 0x61 }); //"ssh-rsa"
            result.AddRange(new byte[] { 0x00, 0x00, 0x00, (byte)parameters.Exponent.Length }); //3 byte exponent; 
            result.AddRange(parameters.Exponent);
            result.AddRange(new byte[] { 0x00, 0x00, 0x00, (byte)parameters.Modulus.Length }); //128 byte modulus
            result.AddRange(parameters.Modulus);

            result.AddRange(new byte[] { 0x00, 0x00, 0x00, (byte)parameters.D.Length }); //128 byte modulus
            result.AddRange(parameters.D);
            result.AddRange(new byte[] { 0x00, 0x00, 0x00, (byte)parameters.P.Length }); //128 byte modulus
            result.AddRange(parameters.P);
            result.AddRange(new byte[] { 0x00, 0x00, 0x00, (byte)parameters.Q.Length }); //128 byte modulus
            result.AddRange(parameters.Q);
            result.AddRange(new byte[] { 0x00, 0x00, 0x00, (byte)parameters.DP.Length }); //128 byte modulus
            result.AddRange(parameters.DP);
            result.AddRange(new byte[] { 0x00, 0x00, 0x00, (byte)parameters.DQ.Length }); //128 byte modulus
            result.AddRange(parameters.DQ);
            result.AddRange(new byte[] { 0x00, 0x00, 0x00, (byte)parameters.InverseQ.Length }); //128 byte modulus
            result.AddRange(parameters.InverseQ);

            return Convert.ToBase64String(result.ToArray());

        }
    }
}
