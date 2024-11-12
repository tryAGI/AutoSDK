//HintName: G.IActivityClient.ActivityMarkThreadAsRead.g.cs
#nullable enable

namespace G
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Mark a thread as read<br/>
        /// Marks a thread as "read." Marking a thread as "read" is equivalent to clicking a notification in your notification inbox on GitHub: https://github.com/notifications.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ActivityMarkThreadAsReadAsync(
            int threadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}