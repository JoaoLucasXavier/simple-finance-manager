using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace sfm.Entities.Notifications
{
    public class Notification
    {
        [NotMapped]
        public string PropertyName { get; set; }

        [NotMapped]
        public string Message { get; set; }

        public List<Notification> Notifications;

        public Notification()
        {
            var notifications = new List<Notification>();
        }

        public bool ValidateStringProperty(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notification
                {
                    Message = "Campo obrigatório",
                    PropertyName = propertyName
                });
                return false;
            }
            return true;
        }

        public bool ValidateIntegerProperty(int value, string propertyName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notification
                {
                    Message = "Campo obrigatório",
                    PropertyName = propertyName
                });
                return false;
            }
            return true;
        }
    }
}
