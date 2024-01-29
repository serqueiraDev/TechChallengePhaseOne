using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechChallengePhaseOne.Domain.Entity;

namespace TechChallengePhaseOne.API.Data
{
    public class TechChallengePhaseOneAPIContext : DbContext
    {
        public TechChallengePhaseOneAPIContext (DbContextOptions<TechChallengePhaseOneAPIContext> options)
            : base(options)
        {
        }

        public DbSet<TechChallengePhaseOne.Domain.Entity.Acao> Acao { get; set; } = default!;
    }
}
