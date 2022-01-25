using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingExamples.ViewModels
{
    #region ItemC is ItemB with INotifyChange in inherited BaseViewModel
    public class ItemC : BaseViewModel
    {
        string _message;
        public string Message
        {
            set => Set<string>(ref _message, value, "Message");
            get => _message;
        }

        DateTime _creation;
        public DateTime Creation
        {
            set => Set<DateTime>(ref _creation, value, "Creation");
            get => _creation;
        }

        public ItemC()
        {
            Message = "A message from item";
            Creation = DateTime.Now;
        }
    }
    #endregion
}
