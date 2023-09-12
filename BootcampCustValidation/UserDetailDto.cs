namespace BootcampCustValidation
{
    public class UserDetailDto
    {
        public int CustomerType { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int MobileNumber { get; set; }
        public int? BillNumber { get; set; } = 0;
        public int? BillAmount { get; set; } = 0;
    }
    //public class Customer : UserDetail
    //{
    //    public override void Test()
    //    {
            
    //    }
    //}
    
}
