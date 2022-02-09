using OrientacaoObjetos.SharedContext;

namespace OrientacaoObjetos.SubscriptionContext
{
    public class User : Base
    {
        public string UserName { get; set; }
        
        public string Password { get; set; }
    }
}