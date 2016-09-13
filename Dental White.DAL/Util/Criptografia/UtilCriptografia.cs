using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Dental_White.DAL.Util.Criptografia
{
    /// <summary>
    /// Classe de Criptografia de Senha.
    /// </summary>
    public class UtilCriptografia
    {
        /// <summary>
        /// Método que Encripta/Codifica a senha.
        /// </summary>
        /// <param name="senha">Recebe uma senha do tipo string.</param>
        /// <returns>Retorna a senha já Encriptada/Codificada pelo método MD5.</returns>
        public static string EncriptarSenha(string senha)
        {
            try
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(senha));

                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
            catch(InvalidOperationException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch(ArgumentNullException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch(EncoderFallbackException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado: " + ex.Message);
            }
        }
    }
}