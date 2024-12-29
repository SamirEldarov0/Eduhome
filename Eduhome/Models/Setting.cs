using System.ComponentModel.DataAnnotations;

namespace Eduhome.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [StringLength(maximumLength:50)]
        public string SupportPhone { get; set; }
        [StringLength(maximumLength: 30)]
        public string HeaderLogo { get; set; }
        [StringLength(maximumLength: 50)]
        public string FooterLogo { get; set; }
        [StringLength(maximumLength: 50)]
        public string ContactPhone { get; set; }
        [StringLength(maximumLength: 200)]
        public string FooterTitle { get; set; }
        [StringLength(maximumLength: 100)]
        public string Address { get; set; }
        [StringLength(maximumLength: 50)]
        public string Email { get; set; }
        [StringLength(maximumLength: 30)]
        public string Site { get; set; }
        [StringLength(maximumLength: 50)]
        public string ChooseTitle { get; set; }
        [StringLength(maximumLength: 350)]
        public string ChooseDesc { get; set; }
        [StringLength(maximumLength: 250)]
        public string ChooseSub { get; set; }
        [StringLength(maximumLength: 30)]
        public string ChooseBtn { get; set; }
        [StringLength(maximumLength: 50)]
        public string ChooseBgImage { get; set; }
        [StringLength(maximumLength: 30)]
        public string TestImg { get; set; }
        [StringLength(maximumLength: 200)]
        public string TestTitle { get; set; }
        [StringLength(maximumLength: 30)]
        public string TestName { get; set; }
        [StringLength(maximumLength: 30)]
        public string TestPosition { get; set; }
        [StringLength(maximumLength: 30)]
        public string AboutTitle { get; set; }
        [StringLength(maximumLength: 32)]
        public string AboutSubtitle { get; set; }
        [StringLength(maximumLength: 300)]
        public string Desc1 { get; set; }
        [StringLength(maximumLength: 250)]
        public string Desc2 { get; set; }
        [StringLength(maximumLength: 30)]
        public string AboutBtn { get; set; }
        [StringLength(maximumLength: 40)]
        public string AboutImg { get; set; }
        [StringLength(maximumLength: 100)]
        public string AboutVideoLink { get; set; }
   
    }
}
