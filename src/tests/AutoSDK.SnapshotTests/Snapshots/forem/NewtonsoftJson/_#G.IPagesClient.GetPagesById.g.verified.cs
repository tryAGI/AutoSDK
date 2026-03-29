//HintName: G.IPagesClient.GetPagesById.g.cs
#nullable enable

namespace G
{
    public partial interface IPagesClient
    {
        /// <summary>
        /// show details for a page<br/>
        /// This endpoint allows the client to retrieve details for a single Page object, specified by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Page> GetPagesByIdAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}