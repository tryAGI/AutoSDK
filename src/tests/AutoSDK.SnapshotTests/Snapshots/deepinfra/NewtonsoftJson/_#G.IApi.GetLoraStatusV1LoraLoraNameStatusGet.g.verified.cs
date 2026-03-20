//HintName: G.IApi.GetLoraStatusV1LoraLoraNameStatusGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get Lora Status
        /// </summary>
        /// <param name="loraName"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetLoraStatusV1LoraLoraNameStatusGetAsync(
            string loraName,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}