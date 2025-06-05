//HintName: G.IApi.GetModelLorasV1ModelModelNameLorasGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get Model Loras
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetModelLorasV1ModelModelNameLorasGetAsync(
            string modelName,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}