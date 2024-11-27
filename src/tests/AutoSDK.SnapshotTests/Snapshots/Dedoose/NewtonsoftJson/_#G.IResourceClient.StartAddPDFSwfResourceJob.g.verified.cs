//HintName: G.IResourceClient.StartAddPDFSwfResourceJob.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// StartAddPDFSwfResourceJob<br/>
        /// StartAddPDFSwfResourceJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartAddPDFSwfResourceJobAsync(
            global::G.StartAddPDFSwfResourceJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartAddPDFSwfResourceJob<br/>
        /// StartAddPDFSwfResourceJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="fileUri"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartAddPDFSwfResourceJobAsync(
            global::System.Guid projectId,
            string title,
            string fileUri,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}