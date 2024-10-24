//HintName: G.IActivityClient.ActivityListReceivedEventsForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// List events received by the authenticated user<br/>
        /// These are events that you've received by watching repositories and following users. If you are authenticated as the<br/>
        /// given user, you will see private events. Otherwise, you'll only see public events.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This API is not built to serve real-time use cases. Depending on the time of day, event latency can be anywhere from 30s to 6h.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Event>> ActivityListReceivedEventsForUserAsync(
            string username,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}