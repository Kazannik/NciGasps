using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NciGasps.Repository
{
    class DepartamentDto
    {
        public DepartamentDto(
            int vnkod, 
            string znachatr, 
            DateTime date_beg, 
            DateTime date_end, 
            string prim, 
            int upkod, 
            string nst, 
            int vrn_record)
        {
            VNKOD = vnkod;
            ZNACHATR = znachatr;
            DATE_BEG = date_beg;
            DATE_END = date_end;
            PRIM = prim;
            UPKOD = upkod;
            NST = nst;
            VRN_RECORD = vrn_record;
        }

        public int VNKOD { get; }

        public string ZNACHATR { get; }

        public DateTime DATE_BEG { get; }

        public DateTime DATE_END { get; }

        public string PRIM { get; }

        public int UPKOD { get; }

        public string NST { get; }

        public int VRN_RECORD { get; }

    }
}
