//HintName: G.IApi.UpdateLoraV1LoraLoraNamePatch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Update Lora
        /// </summary>
        /// <param name="loraName"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateLoraV1LoraLoraNamePatchAsync(
            string loraName,
            global::G.UpdateLoraApiRequest request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Lora
        /// </summary>
        /// <param name="loraName"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="private"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateLoraV1LoraLoraNamePatchAsync(
            string loraName,
            string? xiApiKey = default,
            bool? @private = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}