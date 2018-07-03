using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTableComparison
{
    public class CompareByRow
    {

        public DataTable compare { get; private set; }
        public DataTable to { get; private set; }
        public int RefColIndex { get; set; }
        public List<Cell> coCells { get; private set; }
        public List<Cell> toCells { get; private set; }
        public List<int> coDeletedRows { get; private set; }
        public List<int> toAddedRows { get; private set; }


        public CompareByRow(DataTable compare, DataTable to, int referenceColumnIndex)
        {
            this.compare = compare;
            this.to = to;
            this.RefColIndex = referenceColumnIndex;

            coCells = new List<Cell>();
            toCells = new List<Cell>();


            coDeletedRows = new List<int>();
            toAddedRows = new List<int>();
        }

        public ResultContext CompareTables()
        {
            DeletedRowsAndTables();

            foreach (DataRow toRow in to.Rows)
            {

                bool exists = false;
                string toI = toRow[RefColIndex].ToString();
                foreach (DataRow coRow in compare.Rows)
                {
                    if (toI == coRow[RefColIndex].ToString())
                    {
                        exists = true;
                        break;
                    }

                }
                if (!exists)
                {
                    toAddedRows.Add(to.Rows.IndexOf(toRow));
                }
            }
            return new ResultContext(coCells, toCells, coDeletedRows, toAddedRows);
        }

        private void DeletedRowsAndTables()
        {
            int numOfColumns = compare.Columns.Count;
            int lastCommonRecord = 0;
            bool exists = false;

            foreach (DataRow coRow in compare.Rows)
            {
                foreach (DataRow toRow in to.Rows)
                {
                    if (coRow[RefColIndex].ToString() == toRow[RefColIndex].ToString())
                    {
                        exists = true;
                        lastCommonRecord = to.Rows.IndexOf(toRow);

                        for (int i = 0; i < numOfColumns; i++)
                        {

                            if (coRow[i].ToString() != toRow[i].ToString())
                            {
                                coCells.Add(new Cell(compare.Rows.IndexOf(coRow), i));
                                toCells.Add(new Cell(lastCommonRecord, i));
                            }

                        }
                        break;
                    }
                }

                if (!exists)
                {
                    coDeletedRows.Add(compare.Rows.IndexOf(coRow));
                    lastCommonRecord++;
                }
                exists = false;
            }
        }
    }
}

