using System;

namespace Actio.Common.Events
{
   public class ActitityCreated : IAuthenticatedEvent
   {
        public Guid Id { get;  }
        public Guid UserId { get;  }
        public string Category { get;  }
        public string Name { get;  }
        public string  Description { get;  }
        public DateTime CreatedAt { get;  }

        protected ActitityCreated()
        {
            
        }

        public ActitityCreated(Guid id, Guid userId, string category, string name, string description, DateTime createdAt)
        {
            Id = id;
            UserId = userId;
            Category = category;
            Name = name;
            Description = description;
            CreatedAt = createdAt;
        }
   }
}
