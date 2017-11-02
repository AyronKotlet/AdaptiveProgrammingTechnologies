﻿using Reflector.DataAccess;
using Reflector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflector.Logic
{
    public interface IDataAccessor
    {
        void SaveAssembly(AssemblyMetadata assembly);

        AssemblyMetadata LoadAssembly(string name);
    }

    public class DataAccessor : IDataAccessor
    {
        public DataAccessor(IAssemblyWriter writer, IAssemblyReader reader)
        {
            Writer = writer;
            Reader = reader;
        }

        private IAssemblyWriter Writer { get; set; }
        private IAssemblyReader Reader { get; set; }
        public void SaveAssembly(AssemblyMetadata assembly)
        {
            Writer.Write(assembly);
        }

        public AssemblyMetadata LoadAssembly(string name)
        {
            return Reader.Read(name);
        }
    }
}
