//HintName: G.Ix__AppClient.AppPublicServiceCreateApp.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__AppClient
    {
        /// <summary>
        /// Create an app<br/>
        /// Creates an app.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAppResponse> AppPublicServiceCreateAppAsync(
            string namespaceId,
            global::G.CreateAppBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an app<br/>
        /// Creates an app.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="id">
        /// The app id.<br/>
        /// the app id should be lowercase without any space or special character besides the hyphen,<br/>
        /// it can not start with number or hyphen, and should be less than 32 characters.
        /// </param>
        /// <param name="description">
        /// The app description.
        /// </param>
        /// <param name="tags">
        /// The app tags.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAppResponse> AppPublicServiceCreateAppAsync(
            string namespaceId,
            string id,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}