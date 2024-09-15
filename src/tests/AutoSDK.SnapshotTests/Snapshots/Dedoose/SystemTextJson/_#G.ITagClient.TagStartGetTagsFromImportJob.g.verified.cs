//HintName: G.ITagClient.TagStartGetTagsFromImportJob.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// StartGetTagsFromImportJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="fileURL"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TagStartGetTagsFromImportJobAsync(
            string? token = default,
            string? fileURL = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}