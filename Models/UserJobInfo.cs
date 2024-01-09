namespace DotnetAPI.Models
{
    public partial class UserJobInfo
    {
        public int UserId { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }

        
        //constructor
        public UserJobInfo()
        {
            if (JobTitle == null)
            {
                JobTitle = "";
            }
            if(Department == null){
                Department = "";
            }

        }
    }
}