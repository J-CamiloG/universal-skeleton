using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace skeleton.interfaceCrud
{
    public interface ICrudSystem
    {
        public void Create();
        public void Read();
        public void Update();
        public void Delete();
    }
}