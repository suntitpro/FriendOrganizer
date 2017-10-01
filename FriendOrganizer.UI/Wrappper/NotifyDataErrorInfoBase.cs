﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using FriendOrganizer.UI.ViewModel;

namespace FriendOrganizer.UI.Wrappper
{
    public class NotifyDataErrorInfoBase: ViewModelBase, INotifyDataErrorInfo
    {
        public IEnumerable GetErrors(string propertyName)
        {
            return _errorsByPropertyName.ContainsKey(propertyName) ? _errorsByPropertyName[propertyName] : null;
        }

        public bool HasErrors => _errorsByPropertyName.Any();
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        private Dictionary<string, List<string>> _errorsByPropertyName = new Dictionary<string, List<string>>();

        protected virtual void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            OnPropertyChanged(nameof(HasErrors));
        }

        protected void AddError(string propertyName, string error)
        {
            if (!_errorsByPropertyName.ContainsKey(propertyName))
            {
                _errorsByPropertyName[propertyName] = new List<string>();
            }
            if (!_errorsByPropertyName[propertyName].Contains(error))
            {
                _errorsByPropertyName[propertyName].Add(error);
                OnErrorsChanged(propertyName);
            }

        }

        protected void ClearErrors(string propertyName)
        {
            if (_errorsByPropertyName.ContainsKey(propertyName))
            {
                _errorsByPropertyName.Remove(propertyName);
                OnErrorsChanged(propertyName);
            }
        }
    }
}