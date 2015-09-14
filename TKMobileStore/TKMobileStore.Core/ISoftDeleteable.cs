namespace TKMobileStore.Core
{
    public interface ISoftDeleteable
    {
        bool Deleted { get; set; }
    }
}
