//HintName: G.ILabels2Client.Update2.g.cs
#nullable enable

namespace G
{
    public partial interface ILabels2Client
    {
        /// <summary>
        /// Update labels<br/>
        /// Update labels used for your project without updating the labeling configuration.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Label> Update2Async(
            string id,

            global::G.PatchedLabelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update labels<br/>
        /// Update labels used for your project without updating the labeling configuration.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="approved">
        /// Status of label
        /// </param>
        /// <param name="approvedBy">
        /// User who approved this label
        /// </param>
        /// <param name="createdBy">
        /// User who made this label
        /// </param>
        /// <param name="description">
        /// Label description
        /// </param>
        /// <param name="organization"></param>
        /// <param name="title">
        /// Label title
        /// </param>
        /// <param name="value">
        /// Label value
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Label> Update2Async(
            string id,
            bool? approved = default,
            int? approvedBy = default,
            int? createdBy = default,
            string? description = default,
            int? organization = default,
            string? title = default,
            object? value = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}