using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveStats.Entities.TableRecords
{
    public class Table
    {
        public string TableName { get; set; }
        public int RecordCount { get; set; }
        public int RecordAverage { get; set; }
        public int RecordDifference { get; set; }
        public DateTime OldestRecord { get; set; }
        public DateTime NewestRecord { get; set; }
    }
}
