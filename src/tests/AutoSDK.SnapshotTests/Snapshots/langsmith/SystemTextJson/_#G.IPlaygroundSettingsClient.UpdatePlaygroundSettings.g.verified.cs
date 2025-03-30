//HintName: G.IPlaygroundSettingsClient.UpdatePlaygroundSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IPlaygroundSettingsClient
    {
        /// <summary>
        /// Update Playground Settings<br/>
        /// Update playground settings.
        /// </summary>
        /// <param name="playgroundSettingsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PlaygroundSettingsResponse> UpdatePlaygroundSettingsAsync(
            string playgroundSettingsId,
            global::G.PlaygroundSettingsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Playground Settings<br/>
        /// Update playground settings.
        /// </summary>
        /// <param name="playgroundSettingsId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="settings"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PlaygroundSettingsResponse> UpdatePlaygroundSettingsAsync(
            string playgroundSettingsId,
            string? name = default,
            string? description = default,
            object? settings = default,
            global::G.PlaygroundSavedOptions? options = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}