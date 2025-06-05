//HintName: G.IApi.UploadLoraModelLoraModelPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Upload Lora Model
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeploymentOut> UploadLoraModelLoraModelPostAsync(
            global::G.LoraModelUploadIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Lora Model
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="hfModelName"></param>
        /// <param name="hfToken"></param>
        /// <param name="loraModelName"></param>
        /// <param name="baseModelName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeploymentOut> UploadLoraModelLoraModelPostAsync(
            string hfModelName,
            string loraModelName,
            string? xiApiKey = default,
            string? hfToken = default,
            string? baseModelName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}