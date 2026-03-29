//HintName: G.IAnalyticsGraphsClient.GetAnalyticsGraphsFeedbacksAiModels.g.cs
#nullable enable

namespace G
{
    public partial interface IAnalyticsGraphsClient
    {
        /// <summary>
        /// Get feedbacks per ai_models graph
        /// </summary>
        /// <param name="workspaceSlug"></param>
        /// <param name="timeOfGenerationMin">
        /// Example: 2026-02-23T14:20:31+05:30
        /// </param>
        /// <param name="timeOfGenerationMax">
        /// Example: 2026-02-24T14:20:31+05:30
        /// </param>
        /// <param name="totalUnitsMin"></param>
        /// <param name="totalUnitsMax"></param>
        /// <param name="costMin"></param>
        /// <param name="costMax"></param>
        /// <param name="promptTokenMin"></param>
        /// <param name="promptTokenMax"></param>
        /// <param name="completionTokenMin"></param>
        /// <param name="completionTokenMax"></param>
        /// <param name="statusCode"></param>
        /// <param name="weightedFeedbackMin"></param>
        /// <param name="weightedFeedbackMax"></param>
        /// <param name="virtualKeys"></param>
        /// <param name="configs"></param>
        /// <param name="apiKeyIds"></param>
        /// <param name="metadata"></param>
        /// <param name="aiOrgModel"></param>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="promptSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAnalyticsGraphsFeedbacksAiModelsResponse> GetAnalyticsGraphsFeedbacksAiModelsAsync(
            string workspaceSlug,
            global::System.DateTime timeOfGenerationMin,
            global::System.DateTime timeOfGenerationMax,
            int? totalUnitsMin = default,
            int? totalUnitsMax = default,
            double? costMin = default,
            double? costMax = default,
            int? promptTokenMin = default,
            int? promptTokenMax = default,
            int? completionTokenMin = default,
            int? completionTokenMax = default,
            string? statusCode = default,
            double? weightedFeedbackMin = default,
            double? weightedFeedbackMax = default,
            string? virtualKeys = default,
            string? configs = default,
            string? apiKeyIds = default,
            string? metadata = default,
            string? aiOrgModel = default,
            string? traceId = default,
            string? spanId = default,
            string? promptSlug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}