//HintName: G.Models.FeedbackProjectLogsItemScores.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A dictionary of numeric values (between 0 and 1) to log. These scores will be merged into the existing scores for the project logs event
    /// </summary>
    public sealed partial class FeedbackProjectLogsItemScores
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}