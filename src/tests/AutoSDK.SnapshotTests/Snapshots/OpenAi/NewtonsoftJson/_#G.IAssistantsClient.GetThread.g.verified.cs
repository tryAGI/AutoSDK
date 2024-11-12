//HintName: G.IAssistantsClient.GetThread.g.cs
#nullable enable

namespace G
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Retrieves a thread.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ThreadObject> GetThreadAsync(
            string threadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}