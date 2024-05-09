using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZeldaQuestTracker.Components.Model;

namespace ZeldaQuestTracker.Data
{
    public class ZeldaQuestTrackerContext : DbContext
    {
        public ZeldaQuestTrackerContext (DbContextOptions<ZeldaQuestTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<ZeldaQuestTracker.Components.Model.Quests> Quests { get; set; } = default!;
    }
}
