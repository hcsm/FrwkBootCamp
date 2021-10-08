using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.FrameBook.HttpAggregator.Models
{
    internal class ProfissionalStacksDTO
    {
        public ProfissionalDTO profissionalDTO { get; set; }

        public IList<StacksDTO> StacksExperiencia { get; set; }

        public IList<StacksDTO> StacksDesejaAprender { get; set; }

        public ProfissionalStacksDTO()
        {
            StacksExperiencia = new List<StacksDTO>();
            StacksDesejaAprender = new List<StacksDTO>();
        }
    }
    
}
