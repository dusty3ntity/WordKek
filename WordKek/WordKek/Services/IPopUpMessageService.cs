using System;
using System.Collections.Generic;
using System.Text;

namespace WordKek
{
    public interface IPopUpMessageService
    {
        void GeneratePopUpMessage(string message);
        void GeneratePopUpMessage(string message, uint duration);
    }
}
