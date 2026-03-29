//HintName: G.ILegacyObservationsV1Client.LegacyObservationsV1GetMany.g.cs
#nullable enable

namespace G
{
    public partial interface ILegacyObservationsV1Client
    {
        /// <summary>
        /// Get a list of observations.<br/>
        /// Consider using the [v2 observations endpoint](/api-reference#tag/observationsv2/GET/api/public/v2/observations) for cursor-based pagination and field selection.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="type"></param>
        /// <param name="traceId"></param>
        /// <param name="level"></param>
        /// <param name="parentObservationId"></param>
        /// <param name="environment"></param>
        /// <param name="fromStartTime"></param>
        /// <param name="toStartTime"></param>
        /// <param name="version"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LegacyObservationsViews> LegacyObservationsV1GetManyAsync(
            int? page = default,
            int? limit = default,
            string? name = default,
            string? userId = default,
            string? type = default,
            string? traceId = default,
            global::G.ObservationLevel? level = default,
            string? parentObservationId = default,
            global::System.Collections.Generic.IList<string>? environment = default,
            global::System.DateTime? fromStartTime = default,
            global::System.DateTime? toStartTime = default,
            string? version = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}