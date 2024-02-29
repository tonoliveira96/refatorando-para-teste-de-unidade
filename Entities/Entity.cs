using Flunt.Notifications;
using System.Data.Common;

namespace Store.Domain.Entities
{
  public class Entity: Notifiable
  {
    public Entity(){
      Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }

  }
}