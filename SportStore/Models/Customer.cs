﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.OrderProes = new HashSet<OrderPro>();
        }

        public int IDCus { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập đủ họ tên")]
        [StringLength(100, ErrorMessage = "Tên tối đa là 100 ký tự, tối thiểu là 1 ký tự", MinimumLength = 1)]//Tên đăng nhập tối thiểu là 5 ký tự, tối đa là 50
        [Display(Name = "Họ tên")]
        public string NameCus { get; set; }

        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        [StringLength(100, ErrorMessage = "Tên đăng nhập tối thiểu là 1 ký tự", MinimumLength = 1)]//Tên đăng nhập tối thiểu là 5 ký tự, tối đa là 50
        [RegularExpression(@"\w*", ErrorMessage = "Vui lòng chỉ nhập các ký tự thường và in hoa(a-z) và số")]//Bắt buộc nhập chữ(không nhập số và các kí tự đặt biệt), tự viết lại dòng báo lỗi theo ý mình
        [Display(Name = "Tên đăng nhập")]
        public string AccountCus { get; set; }

        [DisplayName("Nhập mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]//Yêu cầu phải nhập Pass
        [StringLength(100, ErrorMessage = "Mật khẩu tối thiểu là 6 ký tự", MinimumLength = 6)]
        [RegularExpression(@"\w*", ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự, bao gồm chữ và số, không bao gồm ký tự đặc biệt.")]
        [DataType(DataType.Password)]
        public string PassCus { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public Nullable<bool> Gender { get; set; }

        [DisplayName("Nhập số điện thoại")]
        [StringLength(12, ErrorMessage = "Vui lòng nhập đúng số điện thoại", MinimumLength = 10)]
        [RegularExpression(@"(0)[0-9]*", ErrorMessage = "Vui lòng nhập đúng số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string PhoneCus { get; set; }

        [DisplayName("Nhập email")]
        [RegularExpression(@"(\w+)\@gmail.com", ErrorMessage = "Vui lòng nhập đúng địa chỉ email(ví dụ xxx@gmail.com)")]
        [Required(ErrorMessage = "Email không được để trống")]
        public string EmailCus { get; set; }

        [DisplayName("Nhập địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Address { get; set; }

        [NotMapped]
        [Compare("PassCus", ErrorMessage = "Mật khẩu nhập lại không chính xác")]
        [DisplayName("Nhập lại mật khẩu")]

        public string ConfirmPass { get; set; }
        [NotMapped]

        public string ErrorLogin { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderPro> OrderProes { get; set; }
    }
}
