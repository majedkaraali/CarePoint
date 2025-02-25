namespace CarePoint.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }  // Username for login
        public string PasswordHash { get; set; }  // Password hash for security
        public string Role { get; set; }  // Role (Admin, Doctor, Receptionist)
        public string FullName { get; set; }  // Full name of the user
        public string Email { get; set; }  // Email of the user
        public DateTime CreatedAt { get; set; }  // Date when the user account was created
    }

}
