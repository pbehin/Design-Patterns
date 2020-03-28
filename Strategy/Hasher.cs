namespace Strategy
{
    public class Hasher : IHasher
    {
        public Hasher(): this(null)
        {
            
        }

        public Hasher(IPasswordHasher passwordHasher)
        {
            PasswordHasher = passwordHasher;
        }
        public IPasswordHasher PasswordHasher { get; private set; }
        public void SetPasswordHasher(IPasswordHasher passwordHasher) => PasswordHasher = passwordHasher;
    }
}