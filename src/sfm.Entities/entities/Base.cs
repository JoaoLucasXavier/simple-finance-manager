using System;
using System.ComponentModel.DataAnnotations;
using sfm.Entities.Notifications;

namespace sfm.Entities.Entities
{
    public class Base : Notification
    {
        [Display(Name = "Código")]
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        public Base()
        {
            Id = Guid.NewGuid();
        }
    }
}
