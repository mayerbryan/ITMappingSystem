using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Backup
    {
        public Backup(string path, DateOnly date, DateOnly backupExpired)
        {
            Path = path;
            Date = date;
            BackupExpired = backupExpired;
        }

        public string Path { get; private set; }
        public DateOnly Date { get; private set; }
        public DateOnly BackupExpired { get; private set; }
    }
}