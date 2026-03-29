//HintName: G.IScenesClient.CreateSceneFromVideo.g.cs
#nullable enable

namespace G
{
    public partial interface IScenesClient
    {
        /// <summary>
        /// Create scene from video
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> CreateSceneFromVideoAsync(

            global::G.SceneFromVideoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create scene from video
        /// </summary>
        /// <param name="lockFeet"></param>
        /// <param name="maxPersonCount"></param>
        /// <param name="modelVersion"></param>
        /// <param name="sceneName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> CreateSceneFromVideoAsync(
            bool? lockFeet = default,
            int? maxPersonCount = default,
            string? modelVersion = default,
            string? sceneName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}