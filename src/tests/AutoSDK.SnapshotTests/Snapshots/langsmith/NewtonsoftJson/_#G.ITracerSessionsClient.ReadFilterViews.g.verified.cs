//HintName: G.ITracerSessionsClient.ReadFilterViews.g.cs
#nullable enable

namespace G
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Read Filter Views<br/>
        /// Get all filter views for a session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.FilterView>> ReadFilterViewsAsync(
            global::System.Guid sessionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}