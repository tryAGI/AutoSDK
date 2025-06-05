//HintName: G.IApi.ModelsFeaturedModelsFeaturedGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Models Featured
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ModelOut>> ModelsFeaturedModelsFeaturedGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}