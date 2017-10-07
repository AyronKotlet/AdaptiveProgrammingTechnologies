﻿using Reflector.Models;
using System.Runtime.Serialization;
using System.IO;

namespace Reflector.DataAccess.Xml
{
    public class AssemblyXmlSerializer : IAssemblyWriter
    {
        public void Write(AssemblyInfo assemblyInfo)
        {
            Write(assemblyInfo, $"{assemblyInfo.Name}_Model.xml");
        }

        public void Write(AssemblyInfo assemblyInfo, string path)
        {
            var serializer = new DataContractSerializer(assemblyInfo.GetType());
            using (FileStream stream = File.Create(path))
            {
                serializer.WriteObject(stream, assemblyInfo);
            }
        }
    }
}
