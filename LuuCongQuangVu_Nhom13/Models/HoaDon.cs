﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LuuCongQuangVu_Nhom13.Models
{
    [Table("HoaDon")]
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        [Column("MaHD")]
        [StringLength(4)]
        public string MaHd { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayLap { get; set; }
        [StringLength(50)]
        public string NguoiLap { get; set; }
        [StringLength(4)]
        public string Iddocgia { get; set; }

        [ForeignKey(nameof(Iddocgia))]
        [InverseProperty(nameof(Docgium.HoaDons))]
        public virtual Docgium IddocgiaNavigation { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.MaHdNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}