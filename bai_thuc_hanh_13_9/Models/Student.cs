﻿namespace bai_thuc_hanh_13_9.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên
        public string? Name { get; set; } //Họ tên
        public string? Email { get; set; } //Email
        public string? Password { get; set; }//Mật khẩu
        public Branch? Branch { get; set; }//Ngành học
        public Gender? Gender { get; set; }//Giới tính
        public string? Address { get; set; } 
        public bool IsRegular { get; set; }//Hệ: true-chính qui, false-phi cq public string? Address { get; set;
    public DateTime DateOfBorth { get; set; }//Ngày sinh
        public string Image { get;set; }
    }//Địa chỉ
}
