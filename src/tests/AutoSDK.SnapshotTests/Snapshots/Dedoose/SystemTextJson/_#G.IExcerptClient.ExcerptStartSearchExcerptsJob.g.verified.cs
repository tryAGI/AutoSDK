//HintName: G.IExcerptClient.ExcerptStartSearchExcerptsJob.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// StartSearchExcerptsJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="searchText"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExcerptStartSearchExcerptsJobAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? searchText = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}