//HintName: G.IAutomationRuleEvaluatorsClient.CreateAutomationRuleEvaluator.g.cs
#nullable enable

namespace G
{
    public partial interface IAutomationRuleEvaluatorsClient
    {
        /// <summary>
        /// Create automation rule evaluator<br/>
        /// Create automation rule evaluator
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAutomationRuleEvaluatorAsync(

            global::G.AutomationRuleEvaluatorWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create automation rule evaluator<br/>
        /// Create automation rule evaluator
        /// </summary>
        /// <param name="projectId">
        /// Primary project ID (legacy field for backwards compatibility)
        /// </param>
        /// <param name="projectIds">
        /// Project IDs for write operations (used when creating/updating rules)
        /// </param>
        /// <param name="name"></param>
        /// <param name="samplingRate"></param>
        /// <param name="enabled"></param>
        /// <param name="action"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAutomationRuleEvaluatorAsync(
            string name,
            global::System.Guid? projectId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds = default,
            float? samplingRate = default,
            bool? enabled = default,
            global::G.AutomationRuleEvaluatorWriteAction action = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}