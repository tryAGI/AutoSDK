//HintName: G.ILabelsClient.UpdateLabel.g.cs
#nullable enable

namespace G
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Update a label<br/>
        /// Updates an existing label
        /// </summary>
        /// <param name="labelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateLabelAsync(
            global::System.Guid labelId,

            global::G.UpdateLabelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a label<br/>
        /// Updates an existing label
        /// </summary>
        /// <param name="labelId"></param>
        /// <param name="name">
        /// Name of the label
        /// </param>
        /// <param name="description">
        /// Description of the label
        /// </param>
        /// <param name="colorCode">
        /// Color code for the label
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateLabelAsync(
            global::System.Guid labelId,
            string? name = default,
            string? description = default,
            string? colorCode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}