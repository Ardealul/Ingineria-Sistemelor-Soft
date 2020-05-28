using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrmarireBuguri.observer
{
    public interface IObservable
    {
        void addObserver(IObserver observer);
        void removeObserver(IObserver observer);
        void notifyObservers();
    }
}