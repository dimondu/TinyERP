namespace App.Common.Tasks
{
    public interface IExecutable<ContentType>
    {
        int Order { get; }
        void Execute(ContentType context);
    }
}
