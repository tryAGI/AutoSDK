//HintName: G.ITagClient.StartGetTagsFromImportJob.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// StartGetTagsFromImportJob<br/>
        /// StartGetTagsFromImportJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartGetTagsFromImportJobAsync(
            global::G.StartGetTagsFromImportJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartGetTagsFromImportJob<br/>
        /// StartGetTagsFromImportJob
        /// </summary>
        /// <param name="fileURL"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartGetTagsFromImportJobAsync(
            string fileURL,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}