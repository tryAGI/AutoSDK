﻿//HintName: G.IRunClient.ListRuleLogs.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// List Rule Logs<br/>
        /// List logs for a particular rule
        /// </summary>
        /// <param name="ruleId"></param>
        /// <param name="limit">
        /// Default Value: 720
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RuleLogSchema>> ListRuleLogsAsync(
            global::System.Guid ruleId,
            int? limit = default,
            int? offset = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}