//HintName: G.Models.FeedbackExperimentItemScores.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A dictionary of numeric values (between 0 and 1) to log. These scores will be merged into the existing scores for the experiment event
    /// </summary>
    public sealed partial class FeedbackExperimentItemScores
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}