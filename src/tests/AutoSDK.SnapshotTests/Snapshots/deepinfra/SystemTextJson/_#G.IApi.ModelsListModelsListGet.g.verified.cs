//HintName: G.IApi.ModelsListModelsListGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Models List
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ModelOut>> ModelsListModelsListGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}