using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miaudoteme.Domain.ValueObjects
{
    public class ValidateDocuments
    {
        private readonly string _document;
        public ValidateDocuments(string document)
        {
            _document = document;

            if(document.Length > 11)
            {
                ValidarCNPJ(_document);
            }   
                
            ValidarCPF(_document);

        }

        private void ValidarCPF(string cpf)
        {
            if (cpf.Length != 11)
            {
                throw new ArgumentException(message: "Quantidade de caracteres invalida");
            }

            // Calcula o primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            }
            int resto = soma % 11;
            int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

            // Verifica o primeiro dígito verificador
            if (digitoVerificador1 != int.Parse(cpf[9].ToString()))
            {
                throw new ArgumentException(message: "Cpf Invalido");
            }

            // Calcula o segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            }
            resto = soma % 11;
            int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

            // Verifica o segundo dígito verificador
            if (digitoVerificador2 != int.Parse(cpf[10].ToString()))
            {
                throw new ArgumentException(message: "Cpf Invalido");
            }

        }

        private void ValidarCNPJ(string cnpj)
        {
            if (cnpj.Length != 14)
            {
                throw new ArgumentException(message: "Quantidade de caracteres invalida");
            }

            // Calcula o primeiro dígito verificador
            int soma = 0;
            int multiplicador = 2;
            for (int i = 11; i >= 0; i--)
            {
                soma += int.Parse(cnpj[i].ToString()) * multiplicador;
                multiplicador = multiplicador == 9 ? 2 : multiplicador + 1;
            }
            int resto = soma % 11;
            int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

            // Verifica o primeiro dígito verificador
            if (digitoVerificador1 != int.Parse(cnpj[12].ToString()))
            {
                throw new ArgumentException(message: "Cpf Invalido");
            }

            // Calcula o segundo dígito verificador
            soma = 0;
            multiplicador = 2;
            for (int i = 12; i >= 0; i--)
            {
                soma += int.Parse(cnpj[i].ToString()) * multiplicador;
                multiplicador = multiplicador == 9 ? 2 : multiplicador + 1;
            }
            resto = soma % 11;
            int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

            // Verifica o segundo dígito verificador
            if (digitoVerificador2 != int.Parse(cnpj[13].ToString()))
            {
                throw new ArgumentException(message: "Cpf Invalido");
            }

        }
    }
}
