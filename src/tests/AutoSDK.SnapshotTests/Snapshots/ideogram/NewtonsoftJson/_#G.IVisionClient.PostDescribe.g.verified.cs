//HintName: G.IVisionClient.PostDescribe.g.cs
#nullable enable

namespace G
{
    public partial interface IVisionClient
    {
        /// <summary>
        /// Describe an image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescribeResponse> PostDescribeAsync(
            global::G.DescribeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Describe an image
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="imageFilename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescribeResponse> PostDescribeAsync(
            byte[] imageFile,
            string imageFilename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}