//HintName: G.IAutomationRuleEvaluatorsClient.FindEvaluators.g.cs
#nullable enable

namespace G
{
    public partial interface IAutomationRuleEvaluatorsClient
    {
        /// <summary>
        /// Find project Evaluators<br/>
        /// Find project Evaluators
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="id">
        /// Filter automation rules with rule ID containing this value (partial match, like %id%)
        /// </param>
        /// <param name="name">
        /// Filter automation rule evaluators by name (partial match, case insensitive)
        /// </param>
        /// <param name="filters"></param>
        /// <param name="sorting"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutomationRuleEvaluatorPagePublic> FindEvaluatorsAsync(
            global::System.Guid? projectId = default,
            string? id = default,
            string? name = default,
            string? filters = default,
            string? sorting = default,
            int? page = default,
            int? size = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}