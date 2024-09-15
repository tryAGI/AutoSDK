//HintName: G.IPlaygroundSettingsClient.ListPlaygroundSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IPlaygroundSettingsClient
    {
        /// <summary>
        /// List Playground Settings<br/>
        /// Get all playground settings for this tenant id.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PlaygroundSettingsResponse>> ListPlaygroundSettingsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}