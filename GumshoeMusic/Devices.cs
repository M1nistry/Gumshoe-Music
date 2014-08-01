using System;
using System.ComponentModel;

namespace GumshoeMusic
{
    [Serializable()]
    class Devices : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        const string FileName = @"Devices.bin";

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
