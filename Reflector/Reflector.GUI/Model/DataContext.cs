﻿using Reflector.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflector.GUI.Model
{
    abstract class DataContext
    {
        public string LibraryPath { get; set; }

        public abstract ObservableCollection<TreeViewNode> ToTree();

        //public abstract void SerializeToXML(String path);

        public IAssemblyReader Reader { get; set; }

        public IAssemblyWriter Writer { get; set; }
    }
}
