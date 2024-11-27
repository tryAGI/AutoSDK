//HintName: G.ITagClient.UpdateTag.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// UpdateTag<br/>
        /// UpdateTag
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tag> UpdateTagAsync(
            global::G.UpdateTagRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateTag<br/>
        /// UpdateTag
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tag> UpdateTagAsync(
            global::G.Tag tag,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}