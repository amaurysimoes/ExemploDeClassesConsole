using System;

namespace ClassesDevmedia
{
    public class Assinatura : Produto, IExpiravel
    {
        private DateTime dataExpiracao;
        public DateTime DataEspiracao { get => dataExpiracao; set => dataExpiracao = value; }
        
        public TimeSpan GetTempoRestante()
        {
            return dataExpiracao - DateTime.Today;
        }
    }
}
