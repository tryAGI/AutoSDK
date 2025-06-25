//HintName: G.IApi.DeleteLoraModelLoraModelLoraModelNameDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete Lora Model
        /// </summary>
        /// <param name="loraModelName"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteLoraModelLoraModelLoraModelNameDeleteAsync(
            string loraModelName,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}