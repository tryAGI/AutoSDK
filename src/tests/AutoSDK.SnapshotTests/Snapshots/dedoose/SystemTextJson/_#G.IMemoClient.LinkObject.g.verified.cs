//HintName: G.IMemoClient.LinkObject.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// LinkObject<br/>
        /// LinkObject
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> LinkObjectAsync(
            global::G.LinkObjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// LinkObject<br/>
        /// LinkObject
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="resourse"></param>
        /// <param name="excerpt"></param>
        /// <param name="descriptor"></param>
        /// <param name="tag"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> LinkObjectAsync(
            global::System.Guid projectId,
            global::System.Guid memoId,
            global::G.ObjectIdWithPos resourse,
            global::G.ObjectIdWithPos excerpt,
            global::G.ObjectIdWithPos descriptor,
            global::G.ObjectIdWithPos tag,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}