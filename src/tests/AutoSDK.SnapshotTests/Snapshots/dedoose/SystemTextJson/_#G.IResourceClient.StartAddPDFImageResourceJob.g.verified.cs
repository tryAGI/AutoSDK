//HintName: G.IResourceClient.StartAddPDFImageResourceJob.g.cs
#nullable enable

namespace G
{
    public partial interface IResourceClient
    {
        /// <summary>
        /// StartAddPDFImageResourceJob<br/>
        /// StartAddPDFImageResourceJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartAddPDFImageResourceJobAsync(
            global::G.StartAddPDFImageResourceJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartAddPDFImageResourceJob<br/>
        /// StartAddPDFImageResourceJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="fileName"></param>
        /// <param name="fileURI"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartAddPDFImageResourceJobAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            string fileName,
            string fileURI,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}