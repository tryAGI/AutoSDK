//HintName: G.IExcerptClient.StartSearchExcerptsJob.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// StartSearchExcerptsJob<br/>
        /// StartSearchExcerptsJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartSearchExcerptsJobAsync(
            global::G.StartSearchExcerptsJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartSearchExcerptsJob<br/>
        /// StartSearchExcerptsJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="searchText"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartSearchExcerptsJobAsync(
            global::System.Guid projectId,
            string searchText,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}