//HintName: G.IIngestionClient.IngestionBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IIngestionClient
    {
        /// <summary>
        /// **Legacy endpoint for batch ingestion for Langfuse Observability.**<br/>
        /// -&gt; Please use the OpenTelemetry endpoint (`/api/public/otel/v1/traces`). Learn more: https://langfuse.com/integrations/native/opentelemetry<br/>
        /// Within each batch, there can be multiple events.<br/>
        /// Each event has a type, an id, a timestamp, metadata and a body.<br/>
        /// Internally, we refer to this as the "event envelope" as it tells us something about the event but not the trace.<br/>
        /// We use the event id within this envelope to deduplicate messages to avoid processing the same event twice, i.e. the event id should be unique per request.<br/>
        /// The event.body.id is the ID of the actual trace and will be used for updates and will be visible within the Langfuse App.<br/>
        /// I.e. if you want to update a trace, you'd use the same body id, but separate event IDs.<br/>
        /// Notes:<br/>
        /// - Introduction to data model: https://langfuse.com/docs/observability/data-model<br/>
        /// - Batch sizes are limited to 3.5 MB in total. You need to adjust the number of events per batch accordingly.<br/>
        /// - The API does not return a 4xx status code for input errors. Instead, it responds with a 207 status code, which includes a list of the encountered errors.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.IngestionResponse> IngestionBatchAsync(

            global::G.IngestionBatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// **Legacy endpoint for batch ingestion for Langfuse Observability.**<br/>
        /// -&gt; Please use the OpenTelemetry endpoint (`/api/public/otel/v1/traces`). Learn more: https://langfuse.com/integrations/native/opentelemetry<br/>
        /// Within each batch, there can be multiple events.<br/>
        /// Each event has a type, an id, a timestamp, metadata and a body.<br/>
        /// Internally, we refer to this as the "event envelope" as it tells us something about the event but not the trace.<br/>
        /// We use the event id within this envelope to deduplicate messages to avoid processing the same event twice, i.e. the event id should be unique per request.<br/>
        /// The event.body.id is the ID of the actual trace and will be used for updates and will be visible within the Langfuse App.<br/>
        /// I.e. if you want to update a trace, you'd use the same body id, but separate event IDs.<br/>
        /// Notes:<br/>
        /// - Introduction to data model: https://langfuse.com/docs/observability/data-model<br/>
        /// - Batch sizes are limited to 3.5 MB in total. You need to adjust the number of events per batch accordingly.<br/>
        /// - The API does not return a 4xx status code for input errors. Instead, it responds with a 207 status code, which includes a list of the encountered errors.
        /// </summary>
        /// <param name="batch">
        /// Batch of tracing events to be ingested. Discriminated by attribute `type`.
        /// </param>
        /// <param name="metadata">
        /// Optional. Metadata field used by the Langfuse SDKs for debugging.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.IngestionResponse> IngestionBatchAsync(
            global::System.Collections.Generic.IList<global::G.IngestionEvent> batch,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}