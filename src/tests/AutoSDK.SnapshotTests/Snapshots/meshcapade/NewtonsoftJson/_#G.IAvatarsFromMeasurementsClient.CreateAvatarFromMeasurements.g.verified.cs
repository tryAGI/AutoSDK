//HintName: G.IAvatarsFromMeasurementsClient.CreateAvatarFromMeasurements.g.cs
#nullable enable

namespace G
{
    public partial interface IAvatarsFromMeasurementsClient
    {
        /// <summary>
        /// Create avatar from body measurements
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> CreateAvatarFromMeasurementsAsync(

            global::G.MeasurementAvatarRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create avatar from body measurements
        /// </summary>
        /// <param name="gender"></param>
        /// <param name="measurements">
        /// Key-value pairs of measurement names to values
        /// </param>
        /// <param name="modelVersion"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetResponse> CreateAvatarFromMeasurementsAsync(
            global::G.Gender? gender = default,
            global::System.Collections.Generic.Dictionary<string, double>? measurements = default,
            global::G.ModelVersion? modelVersion = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}