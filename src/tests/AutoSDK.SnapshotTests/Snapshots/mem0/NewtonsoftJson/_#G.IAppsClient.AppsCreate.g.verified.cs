//HintName: G.IAppsClient.AppsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Create a new App.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateApp> AppsCreateAsync(

            global::G.CreateApp request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new App.
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateApp> AppsCreateAsync(
            string appId,
            string? name = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}