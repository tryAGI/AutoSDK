//HintName: G.ILabelsClient.DeleteLabel.g.cs
#nullable enable

namespace G
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Delete a label<br/>
        /// Deletes a label
        /// </summary>
        /// <param name="labelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteLabelAsync(
            global::System.Guid labelId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a label<br/>
        /// Deletes a label
        /// </summary>
        /// <param name="labelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<string>> DeleteLabelAsResponseAsync(
            global::System.Guid labelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}