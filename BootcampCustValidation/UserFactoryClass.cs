using Microsoft.AspNetCore.Mvc;

namespace BootcampCustValidation
{

    public class UserFactoryClass
    {
        private Dictionary<int, UserDetail> userDic = new Dictionary<int, UserDetail>
        {
            {1,new CustomerUser() },
            {2, new AdminUser() } 
        };


        public UserDetail Create(int id, UserDetailDto input)
        {
            // Design Pattern : RIP Pattern  
            var asdf =  userDic[id];
            asdf.Address = input.Address;
            asdf.Fullname = input.FullName;
            asdf.PhoneNumber = input.MobileNumber;
            asdf.BillNumber = input.BillNumber;
            asdf.BillAmount = input.BillAmount;
            return asdf;
        }
    } 
    public abstract class UserDetail 
    {
        public string Fullname { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public int? BillNumber { get; set; }

        public int? BillAmount { get; set; }

        public abstract string ResponseClass();
    }

    public class CustomerUser: UserDetail
    {
        public override string ResponseClass()
        {
            if((BillAmount is null || BillAmount is 0) || (BillNumber is null || BillAmount is 0))
            {
                return "Please fill all the value";
            }
            return $"Fullname: {Fullname} , Adddress : {Address}, PhoneNumber : {PhoneNumber},BillNumber : {BillNumber}, BillAmount : {BillAmount} ";
            
        }
    }

    public class AdminUser : UserDetail
    {
        public override string ResponseClass()
        {
            return $"Fullname: {Fullname} , Adddress : {Address}, PhoneNumber : {PhoneNumber},BillNumber : {BillNumber}, BillAmount : {BillAmount} ";
        }
    }
}
