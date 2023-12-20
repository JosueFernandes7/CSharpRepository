using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Entities
{
    class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public LogRecord(string username, DateTime instant)
        {
            Username = username;
            Instant = instant;
        }
        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is LogRecord))
            {
                throw new ArgumentException("Obj is not a LogRecord");
            }
            LogRecord other = obj as LogRecord;

            return Username.Equals(other.Username);
        }

        public override string ToString()
        {
            return Username + " " + Instant.ToString();
        }
    }
}
