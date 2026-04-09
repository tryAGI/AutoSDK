//HintName: G.ILabelsClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Update label link<br/>
        ///         Update a label link that links custom labels to a project labeling configuration, for example if the fromName,  <br/>
        ///         toName, or name parameters for a tag in the labeling configuration change. <br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LabelLink> UpdateAsync(
            string id,

            global::G.PatchedLabelLinkRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update label link<br/>
        ///         Update a label link that links custom labels to a project labeling configuration, for example if the fromName,  <br/>
        ///         toName, or name parameters for a tag in the labeling configuration change. <br/>
        ///         
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fromName">
        /// Tag name
        /// </param>
        /// <param name="label"></param>
        /// <param name="project"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LabelLink> UpdateAsync(
            string id,
            string? fromName = default,
            int? label = default,
            int? project = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}