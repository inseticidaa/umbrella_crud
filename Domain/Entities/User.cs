namespace Domain.Entities
{
    public class User
    {
        #region [User Data]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }

        #endregion [User Data]

        #region [Timestamps]

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        #endregion [Timestamps]
    }
}