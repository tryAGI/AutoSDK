//HintName: G.Models.ArtifactScorecards.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// These are the scorecards that have been evaluated based on the structured outputs extracted during the call.<br/>
    /// To enable, set `assistant.artifactPlan.scorecardIds` or `assistant.artifactPlan.scorecards` with the IDs or objects of the scorecards you want to evaluate.
    /// </summary>
    public sealed partial class ArtifactScorecards
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}