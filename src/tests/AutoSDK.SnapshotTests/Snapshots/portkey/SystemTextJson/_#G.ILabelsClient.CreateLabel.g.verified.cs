//HintName: G.ILabelsClient.CreateLabel.g.cs
#nullable enable

namespace G
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Create a new label<br/>
        /// Creates a new label in the system
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateLabelResponse> CreateLabelAsync(

            global::G.CreateLabelRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new label<br/>
        /// Creates a new label in the system
        /// </summary>
        /// <param name="organisationId">
        /// ID of the organisation
        /// </param>
        /// <param name="workspaceId">
        /// ID or slug of the workspace
        /// </param>
        /// <param name="name">
        /// Name of the label
        /// </param>
        /// <param name="description">
        /// Description of the label
        /// </param>
        /// <param name="colorCode">
        /// Color code for the label
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateLabelResponse> CreateLabelAsync(
            string name,
            global::System.Guid? organisationId = default,
            string? workspaceId = default,
            string? description = default,
            string? colorCode = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}