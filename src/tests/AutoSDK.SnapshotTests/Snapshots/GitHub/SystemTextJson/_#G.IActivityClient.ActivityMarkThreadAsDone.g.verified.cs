//HintName: G.IActivityClient.ActivityMarkThreadAsDone.g.cs
#nullable enable

namespace G
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Mark a thread as done<br/>
        /// Marks a thread as "done." Marking a thread as "done" is equivalent to marking a notification in your notification inbox on GitHub as done: https://github.com/notifications.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActivityMarkThreadAsDoneAsync(
            int threadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}