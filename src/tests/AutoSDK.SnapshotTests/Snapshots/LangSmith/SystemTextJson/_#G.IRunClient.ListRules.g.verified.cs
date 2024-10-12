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
            global::G.AnyOf<global::System.Guid?, object>? datasetId = default,
            global::G.AnyOf<global::System.Guid?, object>? sessionId = default,
            global::G.AnyOf<global::G.ListRulesApiV1RunsRulesGetType2?, object>? type = default,
            global::G.AnyOf<string, object>? nameContains = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}