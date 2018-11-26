using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibioteca.Developers.Criptografia
{
    public class DESCripto
    {
        public string Criptografar(string chave, string mensagem)
        {
            System.Security.Cryptography.DES des = System.Security.Cryptography.DES.Create();
            des.Mode = System.Security.Cryptography.CipherMode.CBC;
            des.KeySize = 64;

            byte[] chaveBytes;
            byte[] criptografiaBytes;
            byte[] mensagemBytes;
            string criptografia;

            chaveBytes = Encoding.UTF8.GetBytes(chave);
            mensagemBytes = Encoding.UTF8.GetBytes(mensagem);


            System.Security.Cryptography.ICryptoTransform cryptor = des.CreateEncryptor(chaveBytes, chaveBytes);
            criptografiaBytes = cryptor.TransformFinalBlock(mensagemBytes, 0, mensagemBytes.Length);
            cryptor.Dispose();

            criptografia = Convert.ToBase64String(criptografiaBytes);
            return criptografia;
        }


        public string Descriptografar(string chave, string criptografia)
        {
            System.Security.Cryptography.DES des = System.Security.Cryptography.DES.Create();
            des.Mode = System.Security.Cryptography.CipherMode.CBC;
            des.KeySize = 64;

            byte[] chaveBytes;
            byte[] criptografiaBytes;
            byte[] mensagemBytes;
            string mensagem;

            chaveBytes = Encoding.UTF8.GetBytes(chave);
            mensagemBytes = Convert.FromBase64String(criptografia);


            System.Security.Cryptography.ICryptoTransform cryptor = des.CreateDecryptor(chaveBytes, chaveBytes);
            criptografiaBytes = cryptor.TransformFinalBlock(mensagemBytes, 0, mensagemBytes.Length);
            cryptor.Dispose();

            mensagem = Encoding.UTF8.GetString(criptografiaBytes);
            return mensagem;
        }

    }
}
