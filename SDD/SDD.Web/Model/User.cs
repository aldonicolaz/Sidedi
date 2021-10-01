//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDD.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.AparaturDesas = new HashSet<AparaturDesa>();
            this.DetailForums = new HashSet<DetailForum>();
            this.DetailPengaduans = new HashSet<DetailPengaduan>();
            this.FcmMessages = new HashSet<FcmMessage>();
            this.FormulirAktaKelahirans = new HashSet<FormulirAktaKelahiran>();
            this.FormulirKKs = new HashSet<FormulirKK>();
            this.FormulirKTPs = new HashSet<FormulirKTP>();
            this.Fora = new HashSet<Forum>();
            this.Pengaduans = new HashSet<Pengaduan>();
            this.UserKaryawans = new HashSet<UserKaryawan>();
            this.UserNelayans = new HashSet<UserNelayan>();
            this.UserPekerjaans = new HashSet<UserPekerjaan>();
            this.UserPerdagangans = new HashSet<UserPerdagangan>();
            this.UserPerikananPeternakans = new HashSet<UserPerikananPeternakan>();
            this.UserPermissions = new HashSet<UserPermission>();
            this.UserPertanianPerkebunans = new HashSet<UserPertanianPerkebunan>();
            this.UserRoles = new HashSet<UserRole>();
        }
    
        public int UserId { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Source { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public Nullable<System.DateTime> LastDirectoryUpdate { get; set; }
        public string UserImage { get; set; }
        public System.DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> UpdateUserId { get; set; }
        public short IsActive { get; set; }
        public string Address { get; set; }
        public Nullable<int> IdHubungan_ { get; set; }
        public string NoKTP { get; set; }
        public string NoKK { get; set; }
        public string PhoneNumber { get; set; }
        public string WaNumber { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public Nullable<int> JenisKelamin { get; set; }
        public Nullable<System.DateTime> TanggalLahir { get; set; }
        public string Description { get; set; }
        public Nullable<long> IdDesa { get; set; }
        public string Pendidikan { get; set; }
        public Nullable<int> IdVersion { get; set; }
        public string FcmToken { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AparaturDesa> AparaturDesas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailForum> DetailForums { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailPengaduan> DetailPengaduans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FcmMessage> FcmMessages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormulirAktaKelahiran> FormulirAktaKelahirans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormulirKK> FormulirKKs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FormulirKTP> FormulirKTPs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Forum> Fora { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pengaduan> Pengaduans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserKaryawan> UserKaryawans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserNelayan> UserNelayans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPekerjaan> UserPekerjaans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPerdagangan> UserPerdagangans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPerikananPeternakan> UserPerikananPeternakans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserPertanianPerkebunan> UserPertanianPerkebunans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
