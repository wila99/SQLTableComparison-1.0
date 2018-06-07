using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTableComparison
{
    public class ResultContext
    {
        public ResultContext(ICollection<Cell> coCells,
        ICollection<Cell> toCells,
        ICollection<int> deletedRows,
        ICollection<int> addedRows)
        {
            this.coCells = coCells;
            this.toCells = toCells;
            this.meCells = meCells;
            this.deletedRows = deletedRows;
            this.addedRows = addedRows;

        }

        public ResultContext(ICollection<Cell> coCells, ICollection<Cell> toCells)
        {
            this.coCells = coCells;
            this.toCells = toCells;
        }

        public ICollection<Cell> coCells { get; private set; }
        public ICollection<Cell> toCells { get; private set; }
        public ICollection<Cell> meCells { get; private set; }
        public ICollection<int> deletedRows { get; private set; }
        public ICollection<int> addedRows { get; private set; }

    }
}

