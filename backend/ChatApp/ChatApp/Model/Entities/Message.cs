using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ChatApp.Model.Enums;

namespace ChatApp.Model.Entities
{
    public class Message
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Sender_Id { get; set; }

        [Required]
        public int Reciever_Id { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public Status Status { get; set; } 

        [Required]
        public DateTime Sent_Date { get; set; }

        [Required]
        public DateTime Seen_Date { get; set; }


    }
}
