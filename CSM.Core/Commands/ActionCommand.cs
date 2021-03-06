﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CSM.Core
{
    public class ActionCommand : IItem, ICommand
    {
        #region Fields
        /// <summary>
        /// Action handed by Constructor
        /// </summary>
        private Action _action;
        #endregion

        public ActionCommand(Action action)
        {
            _action = action;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        protected void OnIsEnabledChanged()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            
            if (parameter != null)
            {
                _action();
            }
        }

        public string Content
        {
            get;
            set;
        }
    }
}
