using OrientacaoObjetos.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
