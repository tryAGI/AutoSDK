//HintName: G.IRunClient.ListRules.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// List Rules<br/>
        /// List all run rules.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="sessionId"></param>
        /// <param name="type"></param>
        /// <param name="nameContains"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RunRulesSchema>> ListRulesAsync(
            global::System.Guid? datasetId = default,
            global::System.Guid? sessionId = default,
            global::G.ListRulesApiV1RunsRulesGetType? type = default,
            string? nameContains = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}