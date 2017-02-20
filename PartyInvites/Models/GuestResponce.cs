using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace PartyInvites.Models
{
    public class GuestResponce
    {
        [Required(ErrorMessage = "Вы не ввели имя")]
        public  string Name { get; set; }
        [Required(ErrorMessage = "Введите адрес електронной почты")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Вы ввели не коректный адрес електронной почты")]
        public  string Email { get; set; }
        [Required(ErrorMessage = "Введите телефон")]
        public  string Phone { get; set; }
        [Required(ErrorMessage = "Укажите примите ли Вы участие в вечеринке")]
        public  bool? WillAttend { get; set; }
    }
}