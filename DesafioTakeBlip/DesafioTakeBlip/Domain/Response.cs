using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTakeBlip.Domain
{
    public class Response
    {
        public int totalCount { get; set; }
        public Repository firstRepository { get; set;}
        public Repository secondRepository { get; set; }
        public Repository thirdRepository { get; set; }
        public Repository fourthRepository { get; set; }

        public Repository fifthRespository { get; set; }

    }
}
