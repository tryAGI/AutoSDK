//HintName: G.IApi.ListVoicesPublicVoicesGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List Voices
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Asset>> ListVoicesPublicVoicesGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}