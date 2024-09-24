using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullOOP.AppUI.OopPrinciples.Coupling
{
    public interface INotificationService
    {
        void SendNotification(string message);
    }
}
