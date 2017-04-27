namespace App.Common.Tasks
{
    public interface IBaseTask<ContextType>: IExecutable<ContextType>
    {
        
        bool IsValid(ApplicationType type);
    }
}