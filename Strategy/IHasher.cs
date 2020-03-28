namespace Strategy
{
    public interface IHasher
    {
        IPasswordHasher PasswordHasher { get; }
        void SetPasswordHasher(IPasswordHasher passwordHasher);
    }
}