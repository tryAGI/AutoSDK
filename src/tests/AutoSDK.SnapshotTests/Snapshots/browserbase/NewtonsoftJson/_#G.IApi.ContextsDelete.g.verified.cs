//HintName: G.IApi.ContextsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete a Context
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ContextsDeleteAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}