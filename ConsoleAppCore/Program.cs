using ConsoleAppCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleAppCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{nameof(Main)} Started.");

            string passwordPlainText = "Abc@123$";

            HashPassword hashPassword = new HashPassword();
            var hasher = new PasswordHasherOptions();
            string encryptPassword = hashPassword.EncryptString(passwordPlainText);

            Console.WriteLine($"Password Plain Text: {passwordPlainText}");
            Console.WriteLine($"Password Encrypted: {encryptPassword}");

            // Tạo Role: Admin
            // ----------------------------------------------------------
            // IdRole = 1
            var adminRole = new Role()
            {
                RoleName = "Admin"
            };

            using (BOOKSTOREContext ctx = new BOOKSTOREContext())
            {
                ctx.Roles.Add(adminRole);
                ctx.SaveChanges();
            }

            // Tạo User           
            // ----------------------------------------------------------

            // UserId = 1
            var user = new Userinfor()
            {
                Age = 22,
                Email = "chien@gmail.com",
                Gender = 1,
                Password = encryptPassword,
                Phone = "0982411958",
                Username = "chien"
            };

            using (BOOKSTOREContext ctx = new BOOKSTOREContext())
            {
                ctx.Userinfors.Add(user);
                ctx.SaveChanges();
            }

            // Tạo UserRole: 'Chien' co Role la 'Admin'
            // ----------------------------------------------------------
            var userRole = new UserRole()
            {
                IdRole = 1,
                UserId = 1,
            };

            using (BOOKSTOREContext ctx = new BOOKSTOREContext())
            {
                ctx.UserRoles.Add(userRole);
                ctx.SaveChanges();
            }

            Console.WriteLine($"{nameof(Main)} Finished.");
            Console.Write("DONE. Press any key to exit...");
            Console.ReadKey();
        }
    }

    internal class HashPassword
    {
        private string keyString = "AAECAwQFBgcICQoLDA0ODw==";
        public HashPassword()
        {

        }
        public string EncryptString(string text)
        {
            var key = Encoding.UTF8.GetBytes(keyString);

            using (var aesAlg = Aes.Create())
            {
                using (var encryptor = aesAlg.CreateEncryptor(key, aesAlg.IV))
                {
                    using (var msEncrypt = new MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(text);
                        }

                        var iv = aesAlg.IV;

                        var decryptedContent = msEncrypt.ToArray();

                        var result = new byte[iv.Length + decryptedContent.Length];

                        Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
                        Buffer.BlockCopy(decryptedContent, 0, result, iv.Length, decryptedContent.Length);

                        return Convert.ToBase64String(result);
                    }
                }
            }
        }

        public string DecryptString(string cipherText)
        {
            var fullCipher = Convert.FromBase64String(cipherText);

            var iv = new byte[16];
            var cipher = new byte[16];

            Buffer.BlockCopy(fullCipher, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(fullCipher, iv.Length, cipher, 0, iv.Length);
            var key = Encoding.UTF8.GetBytes(keyString);

            using (var aesAlg = Aes.Create())
            {
                using (var decryptor = aesAlg.CreateDecryptor(key, iv))
                {
                    string result;
                    using (var msDecrypt = new MemoryStream(cipher))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                result = srDecrypt.ReadToEnd();
                            }
                        }
                    }

                    return result;
                }
            }
        }
    }
}