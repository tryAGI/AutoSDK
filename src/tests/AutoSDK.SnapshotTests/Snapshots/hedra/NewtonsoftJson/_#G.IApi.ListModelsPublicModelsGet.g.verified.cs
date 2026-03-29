//HintName: G.IApi.ListModelsPublicModelsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List Models
        /// </summary>
        /// <param name="types"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AIModel>> ListModelsPublicModelsGetAsync(
            global::System.Collections.Generic.IList<string>? types = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}