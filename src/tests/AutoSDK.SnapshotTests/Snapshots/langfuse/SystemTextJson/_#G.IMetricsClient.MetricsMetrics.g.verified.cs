//HintName: G.IMetricsClient.MetricsMetrics.g.cs
#nullable enable

namespace G
{
    public partial interface IMetricsClient
    {
        /// <summary>
        /// Get metrics from the Langfuse project using a query object. V2 endpoint with optimized performance.<br/>
        /// ## V2 Differences<br/>
        /// - Supports `observations`, `scores-numeric`, and `scores-categorical` views only (traces view not supported)<br/>
        /// - Direct access to tags and release fields on observations<br/>
        /// - Backwards-compatible: traceName, traceRelease, traceVersion dimensions are still available on observations view<br/>
        /// - High cardinality dimensions are not supported and will return a 400 error (see below)<br/>
        /// For more details, see the [Metrics API documentation](https://langfuse.com/docs/metrics/features/metrics-api).<br/>
        /// ## Available Views<br/>
        /// ### observations<br/>
        /// Query observation-level data (spans, generations, events).<br/>
        /// **Dimensions:**<br/>
        /// - `environment` - Deployment environment (e.g., production, staging)<br/>
        /// - `type` - Type of observation (SPAN, GENERATION, EVENT)<br/>
        /// - `name` - Name of the observation<br/>
        /// - `level` - Logging level of the observation<br/>
        /// - `version` - Version of the observation<br/>
        /// - `tags` - User-defined tags<br/>
        /// - `release` - Release version<br/>
        /// - `traceName` - Name of the parent trace (backwards-compatible)<br/>
        /// - `traceRelease` - Release version of the parent trace (backwards-compatible, maps to release)<br/>
        /// - `traceVersion` - Version of the parent trace (backwards-compatible, maps to version)<br/>
        /// - `providedModelName` - Name of the model used<br/>
        /// - `promptName` - Name of the prompt used<br/>
        /// - `promptVersion` - Version of the prompt used<br/>
        /// - `startTimeMonth` - Month of start_time in YYYY-MM format<br/>
        /// **Measures:**<br/>
        /// - `count` - Total number of observations<br/>
        /// - `latency` - Observation latency (milliseconds)<br/>
        /// - `streamingLatency` - Generation latency from completion start to end (milliseconds)<br/>
        /// - `inputTokens` - Sum of input tokens consumed<br/>
        /// - `outputTokens` - Sum of output tokens produced<br/>
        /// - `totalTokens` - Sum of all tokens consumed<br/>
        /// - `outputTokensPerSecond` - Output tokens per second<br/>
        /// - `tokensPerSecond` - Total tokens per second<br/>
        /// - `inputCost` - Input cost (USD)<br/>
        /// - `outputCost` - Output cost (USD)<br/>
        /// - `totalCost` - Total cost (USD)<br/>
        /// - `timeToFirstToken` - Time to first token (milliseconds)<br/>
        /// - `countScores` - Number of scores attached to the observation<br/>
        /// ### scores-numeric<br/>
        /// Query numeric and boolean score data.<br/>
        /// **Dimensions:**<br/>
        /// - `environment` - Deployment environment<br/>
        /// - `name` - Name of the score (e.g., accuracy, toxicity)<br/>
        /// - `source` - Origin of the score (API, ANNOTATION, EVAL)<br/>
        /// - `dataType` - Data type (NUMERIC, BOOLEAN)<br/>
        /// - `configId` - Identifier of the score config<br/>
        /// - `timestampMonth` - Month in YYYY-MM format<br/>
        /// - `timestampDay` - Day in YYYY-MM-DD format<br/>
        /// - `value` - Numeric value of the score<br/>
        /// - `traceName` - Name of the parent trace<br/>
        /// - `tags` - Tags<br/>
        /// - `traceRelease` - Release version<br/>
        /// - `traceVersion` - Version<br/>
        /// - `observationName` - Name of the associated observation<br/>
        /// - `observationModelName` - Model name of the associated observation<br/>
        /// - `observationPromptName` - Prompt name of the associated observation<br/>
        /// - `observationPromptVersion` - Prompt version of the associated observation<br/>
        /// **Measures:**<br/>
        /// - `count` - Total number of scores<br/>
        /// - `value` - Score value (for aggregations)<br/>
        /// ### scores-categorical<br/>
        /// Query categorical score data. Same dimensions as scores-numeric except uses `stringValue` instead of `value`.<br/>
        /// **Measures:**<br/>
        /// - `count` - Total number of scores<br/>
        /// ## High Cardinality Dimensions<br/>
        /// The following dimensions cannot be used as grouping dimensions in v2 metrics API as they can cause performance issues.<br/>
        /// Use them in filters instead.<br/>
        /// **observations view:**<br/>
        /// - `id` - Use traceId filter to narrow down results<br/>
        /// - `traceId` - Use traceId filter instead<br/>
        /// - `userId` - Use userId filter instead<br/>
        /// - `sessionId` - Use sessionId filter instead<br/>
        /// - `parentObservationId` - Use parentObservationId filter instead<br/>
        /// **scores-numeric / scores-categorical views:**<br/>
        /// - `id` - Use specific filters to narrow down results<br/>
        /// - `traceId` - Use traceId filter instead<br/>
        /// - `userId` - Use userId filter instead<br/>
        /// - `sessionId` - Use sessionId filter instead<br/>
        /// - `observationId` - Use observationId filter instead<br/>
        /// ## Aggregations<br/>
        /// Available aggregation functions: `sum`, `avg`, `count`, `max`, `min`, `p50`, `p75`, `p90`, `p95`, `p99`, `histogram`<br/>
        /// ## Time Granularities<br/>
        /// Available granularities for timeDimension: `auto`, `minute`, `hour`, `day`, `week`, `month`<br/>
        /// - `auto` bins the data into approximately 50 buckets based on the time range
        /// </summary>
        /// <param name="query"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MetricsV2Response> MetricsMetricsAsync(
            string query,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}