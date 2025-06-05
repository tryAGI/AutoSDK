//HintName: G.IApi.ModelVersionsModelsModelNameVersionsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Model Versions
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ModelVersionOut>> ModelVersionsModelsModelNameVersionsGetAsync(
            string modelName,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}