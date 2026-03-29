//HintName: G.Models.ChatAnalysisCustomAnalysisData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom analysis data that was extracted based on the schema defined in chat agent post chat analysis data. Can be empty if nothing is specified.
    /// </summary>
    public sealed partial class ChatAnalysisCustomAnalysisData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}