﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_Prog_Odev.Models
{
    // veri tabanındaki tablo ismi ataması
    [Table("Available_Prof")]
    public class Available_Prof
    {
        // Primary Key olarak ayarlandı, Identity otomatik artılacak ve gerekli alan/boş geçilemez
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required]
        public int AvailableProfID { get; set; }

        // zorunlu alan
        [Required]
        public DateTime AvailableProfDate { get; set; }

        // bu müsait olunan zaman dilimi randevu alınabilir mi yoksa daha önceden doldu mu, kontrol sağlayabilmek adına
        [Required]
        public bool IsAvailable { get; set; }




        // TABLOLAR ARASI İLİŞKİLER;;;


        // available_prof ve professor arası çoka-çok ilişki tanımlanır (virtual anahtar kelimesi ile)
        // bir available_prof birden fazla professor 'a ait olabilir, bir professor birden fazla available_prof 'a sahip olabilir
        public virtual List<Professor> ProfessorList { get; set; }

        // available_prof ve appointment arası bire-bir ilişki tanımlanır (virtual anahtar kelimesi ile)
        // bir available_prof bir appointment 'a sahip olabilir, bir appointment bir available_prof 'a ait olabilir
        public virtual Appointment AppointmentR { get; set; }
        // değişkenin sonuna R koyulma sebebi Relationship 'leri tuttuğu anlaşılsın diye
    }
}