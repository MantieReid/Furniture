﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Furniture.Relationship
{
    public abstract class Child : INotifyPropertyChanged
    {
        protected Child(IParent parent = null)
        {
            Parent = parent;
        }

        public IParent Parent { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Child AddParent(IParent parent)
        {
            Parent = parent;
            return this;
        }

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            Parent?.OnPropertyChanged();
        }
    }
}