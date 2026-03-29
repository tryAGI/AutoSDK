//HintName: G.IApi.Info.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Info<br/>
        /// Returns service information, including name and version.<br/>
        /// Returns:<br/>
        ///     InfoResponse: A response containing the service name and version.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InfoResponse> InfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}