namespace Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Cart Cart { get; set; }
        public List<Order> Orders { get; set; }
        public Favorite[] Favorites { get; set; }

        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        public void Login()
        {
            // Login logic
        }

        public void Logout()
        {
            // Logout logic
        }

        public void Register()
        {
            // Register logic
        }

        public void AddToFavorite(int productId)
        {
            // Add to favorite logic
        }

        public void RemoveFromFavorite(int productId)
        {
            // Remove from favorite logic
        }
    }
}