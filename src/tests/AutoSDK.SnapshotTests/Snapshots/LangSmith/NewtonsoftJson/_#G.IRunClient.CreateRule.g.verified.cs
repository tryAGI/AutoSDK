//HintName: G.IRunClient.CreateRule.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Create Rule<br/>
        /// Create a new run rule.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunRulesSchema> CreateRuleAsync(
            global::G.RunRulesCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Rule<br/>
        /// Create a new run rule.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="sessionId"></param>
        /// <param name="isEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="datasetId"></param>
        /// <param name="samplingRate"></param>
        /// <param name="filter"></param>
        /// <param name="traceFilter"></param>
        /// <param name="treeFilter"></param>
        /// <param name="backfillFrom"></param>
        /// <param name="useCorrectionsDataset">
        /// Default Value: false
        /// </param>
        /// <param name="numFewShotExamples"></param>
        /// <param name="extendOnly">
        /// Default Value: false
        /// </param>
        /// <param name="addToAnnotationQueueId"></param>
        /// <param name="addToDatasetId"></param>
        /// <param name="addToDatasetPreferCorrection">
        /// Default Value: false
        /// </param>
        /// <param name="evaluators"></param>
        /// <param name="codeEvaluators"></param>
        /// <param name="alerts"></param>
        /// <param name="webhooks"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunRulesSchema> CreateRuleAsync(
            string displayName,
            double samplingRate,
            global::G.AnyOf<global::System.Guid?, object>? sessionId = default,
            bool? isEnabled = true,
            global::G.AnyOf<global::System.Guid?, object>? datasetId = default,
            global::G.AnyOf<string, object>? filter = default,
            global::G.AnyOf<string, object>? traceFilter = default,
            global::G.AnyOf<string, object>? treeFilter = default,
            global::G.AnyOf<global::System.DateTime?, object>? backfillFrom = default,
            bool? useCorrectionsDataset = false,
            global::G.AnyOf<int?, object>? numFewShotExamples = default,
            bool? extendOnly = false,
            global::G.AnyOf<global::System.Guid?, object>? addToAnnotationQueueId = default,
            global::G.AnyOf<global::System.Guid?, object>? addToDatasetId = default,
            bool? addToDatasetPreferCorrection = false,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.EvaluatorTopLevel>, object>? evaluators = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.CodeEvaluatorTopLevel>, object>? codeEvaluators = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.RunRulesPagerdutyAlertSchema>, object>? alerts = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.RunRulesWebhookSchema>, object>? webhooks = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}