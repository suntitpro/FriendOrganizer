﻿using System.Windows.Input;
using FriendOrganizer.UI.Event;
using Prism.Commands;
using Prism.Events;

namespace FriendOrganizer.UI.ViewModel
{
    public class NavigationItemViewModel : ViewModelBase
    {
        private IEventAggregator _eventAggregator;
        private string _displayMember;

        public NavigationItemViewModel(int id, string displayMember, IEventAggregator eventAggregator)
        {
            Id = id;
            DisplayMember = displayMember;
            _eventAggregator = eventAggregator;
            OpenFriendDetailViewCommand = new DelegateCommand(OnOpenFriendDetailView);
        }

        public int Id { get; set; }
        public string DisplayMember
        {
            get { return _displayMember; }
            set
            {
                _displayMember = value; 
                OnPropertyChanged();
            }
        }

        public ICommand OpenFriendDetailViewCommand { get; }

        private void OnOpenFriendDetailView()
        {
            _eventAggregator.GetEvent<OpenFriendDetailViewEvent>()
                .Publish(Id);
        }
    }
}