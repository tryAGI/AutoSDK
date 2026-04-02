//HintName: G.IRetentionRulesClient.CreateRetentionRule.g.cs
#nullable enable

namespace G
{
    public partial interface IRetentionRulesClient
    {
        /// <summary>
        /// Create retention rule<br/>
        /// Create a new retention rule. Auto-deactivates any existing active rule for the same scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RetentionRulePublic> CreateRetentionRuleAsync(

            global::G.RetentionRuleWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create retention rule<br/>
        /// Create a new retention rule. Auto-deactivates any existing active rule for the same scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.RetentionRulePublic>> CreateRetentionRuleAsResponseAsync(

            global::G.RetentionRuleWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create retention rule<br/>
        /// Create a new retention rule. Auto-deactivates any existing active rule for the same scope.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationLevel">
        /// Set to true to create an organization-level rule<br/>
        /// Included only in requests
        /// </param>
        /// <param name="retention"></param>
        /// <param name="applyToPast"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RetentionRulePublic> CreateRetentionRuleAsync(
            bool organizationLevel,
            global::G.RetentionRuleWriteRetention retention,
            global::System.Guid? projectId = default,
            bool? applyToPast = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}