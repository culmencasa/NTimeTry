using System.ComponentModel;

namespace NTT.PO
{
    public class BaseEntityWithNotify : BaseEntity, INotifyPropertyChanged
    {
        #region INotifyPropertyChanged实现

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
