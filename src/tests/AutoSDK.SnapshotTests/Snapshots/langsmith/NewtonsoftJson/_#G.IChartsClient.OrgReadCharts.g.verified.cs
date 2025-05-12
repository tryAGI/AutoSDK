﻿//HintName: G.IChartsClient.OrgReadCharts.g.cs
#nullable enable

namespace G
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Org Read Charts<br/>
        /// Get all charts for the tenant.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomChartsResponse> OrgReadChartsAsync(
            global::G.CustomChartsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Org Read Charts<br/>
        /// Get all charts for the tenant.
        /// </summary>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stride">
        /// Timedelta input.
        /// </param>
        /// <param name="omitData">
        /// Default Value: false
        /// </param>
        /// <param name="afterIndex"></param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomChartsResponse> OrgReadChartsAsync(
            string? timezone = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::G.TimedeltaInput? stride = default,
            bool? omitData = default,
            int? afterIndex = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}