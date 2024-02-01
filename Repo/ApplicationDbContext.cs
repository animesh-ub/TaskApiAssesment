using TaskApi.DataContext;

namespace TaskApi.Repo
{
    internal class ApplicationDbContext
    {
        public object Task { get; internal set; }

        public static implicit operator ApplicationDbContext(TaskDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}