namespace Strategy
{
    public interface IPasswordHasher
    {
        byte[] Hash(string password);
    }
}