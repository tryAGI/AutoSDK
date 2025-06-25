﻿//HintName: G.IActivityClient.ActivityListPublicEvents.g.cs
#nullable enable

namespace G
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// List public events<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This API is not built to serve real-time use cases. Depending on the time of day, event latency can be anywhere from 30s to 6h.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Event>> ActivityListPublicEventsAsync(
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}