//HintName: G.IAutomationRuleEvaluatorsClient.GetEvaluatorById.g.cs
#nullable enable

namespace G
{
    public partial interface IAutomationRuleEvaluatorsClient
    {
        /// <summary>
        /// Get automation rule evaluator by id<br/>
        /// Get automation rule by id
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutomationRuleEvaluatorPublic> GetEvaluatorByIdAsync(
            global::System.Guid id,
            global::System.Guid? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}