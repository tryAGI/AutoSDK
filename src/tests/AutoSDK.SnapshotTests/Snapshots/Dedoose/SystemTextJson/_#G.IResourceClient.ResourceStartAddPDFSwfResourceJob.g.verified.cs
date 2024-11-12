//HintName: G.IResourceClient.ResourceStartAddPDFSwfResourceJob.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// StartAddPDFSwfResourceJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="fileUri"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResourceStartAddPDFSwfResourceJobAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? title = default,
            string? fileUri = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}