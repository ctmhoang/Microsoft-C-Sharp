using System;
using System.IO;

namespace Mod3_Dispose
{
    abstract class Person : IDisposable
    {
        public virtual string Name { get; set; }

        protected bool isDiposed;

        private StreamWriter writer;

        protected Person(string name)
        {
            Name = name;
            writer = null;
            isDiposed = false;
        }

        public void writeToFile(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (isDiposed) throw new ObjectDisposedException("Person");
            using (writer = new StreamWriter(name,true))
            {
                writer.WriteLine(this.ToString());
                writer.Close();
                writer = null;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (isDiposed) return;
            if (disposing)
            {
                writer?.Close();
                isDiposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Person()
        {
            Dispose(writer != null);
        }
    }
}