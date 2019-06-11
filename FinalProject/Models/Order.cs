using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{

    public enum Amount 
        {
        [Display(Name="1")]
        A  ,
        [Display(Name = "2")]
        B  ,
        [Display(Name = "3")]
        C ,
        [Display(Name = "4")]
        D,
        [Display(Name = "5")]
        E  ,
        [Display(Name = "6")]
        F ,
        }

    public enum Count
    {

        one = 1, two = 2, three = 3, four = 4, five = 5, six = 6
    }
    public class Order
    {
        
        public int OrderID { get; set; }
        public int MemberID { get; set; }
        public int TicketID { get; set; }
        public Amount? Amount { get; set; }

        public virtual Member Member { get; set; }
        public virtual Ticket Ticket { get; set; }
        [Required]
        [Display(Name ="購買數量")]
        public Amount Amount2 { get;  set; }
        [DisplayName("購買數量")]
        public int Count2 { get; internal set; }


    }
    }
