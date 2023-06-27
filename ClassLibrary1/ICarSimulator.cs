using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface ICarSimulator
    {
        void SetStatus(CarStatus carstatus);
        void SetDirection(Direction direction);
        //void SelectMenuOption(MenuOption option);
        //void DriverFatigue();
        void RefuelGasoline();
        void Rest();
        void Reverse();
        void DriveForward();
        void Exit();
    }
}
