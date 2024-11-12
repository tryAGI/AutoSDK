//HintName: G.IMemoClient.MemoStartSearchMemosJob.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// StartSearchMemosJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="searchText"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MemoStartSearchMemosJobAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? searchText = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}