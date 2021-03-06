﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CSHTGT.Data.Models
{
    [Table("CanBo")]
    public class CanBo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDCanBo { get; set; }
        public int MaDonVi { get; set; }

        [MaxLength(250)]
        public string HoTen { get; set; }

        [MaxLength(250)]
        public string CMND { get; set; }

        [MaxLength(250)]
        public string DiaChi { get; set; }

        [MaxLength(250)]
        public string Email { get; set; }
        public DateTime NgaySinh { get; set; }

        [MaxLength(11)]
        public string SDT { get; set; }

        [MaxLength(250)]
        public string UserName { get; set; }

        [MaxLength(250)]
        public string Password { get; set; }

        [ForeignKey("MaDonVi")]
        public virtual DonVi DonVi { get; set; }
        public List<BienBanViPham> BienBanViPhams { get; set; }
        public List<HoSoDangKyPhuongTien> HoSoDangKyXes { get; set; }
        public List<HoSoThuHoiPhuongTien> HoSoThuHoiXes { get; set; }
        public List<HoSoSangTenPhuongTien> HoSoSangTenXes { get; set; }
    }
}
