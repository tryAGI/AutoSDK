//HintName: G.ILegacyObservationsV1Client.LegacyObservationsV1Get.g.cs
#nullable enable

namespace G
{
    public partial interface ILegacyObservationsV1Client
    {
        /// <summary>
        /// Get a observation
        /// </summary>
        /// <param name="observationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObservationsView> LegacyObservationsV1GetAsync(
            string observationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}