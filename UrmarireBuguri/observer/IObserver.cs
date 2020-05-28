using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrmarireBuguri.observer
{
    public interface IObserver
    {
        void setObservers(List<IObserver> observers);

        void update();
    }
}
