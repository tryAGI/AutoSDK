//HintName: G.IAvatarsFromBetasClient.CreateAvatarFromBetas.g.cs
#nullable enable

namespace G
{
    public partial interface IAvatarsFromBetasClient
    {
        /// <summary>
        /// Create avatar from SMPL shape parameters
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> CreateAvatarFromBetasAsync(

            global::G.BetasAvatarRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create avatar from SMPL shape parameters
        /// </summary>
        /// <param name="betas">
        /// SMPL shape parameters
        /// </param>
        /// <param name="fps"></param>
        /// <param name="gender"></param>
        /// <param name="images"></param>
        /// <param name="inputMeasurements"></param>
        /// <param name="modelVersion"></param>
        /// <param name="name"></param>
        /// <param name="poseName"></param>
        /// <param name="poses"></param>
        /// <param name="predictedMeasurements"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> CreateAvatarFromBetasAsync(
            global::System.Collections.Generic.IList<double>? betas = default,
            double? fps = default,
            global::G.Gender? gender = default,
            global::G.ImageTagLinks? images = default,
            global::System.Collections.Generic.Dictionary<string, double>? inputMeasurements = default,
            global::G.ModelVersion? modelVersion = default,
            string? name = default,
            string? poseName = default,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? poses = default,
            global::System.Collections.Generic.Dictionary<string, double>? predictedMeasurements = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}