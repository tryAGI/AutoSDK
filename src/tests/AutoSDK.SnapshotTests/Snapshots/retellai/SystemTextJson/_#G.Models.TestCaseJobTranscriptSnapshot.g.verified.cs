//HintName: G.Models.TestCaseJobTranscriptSnapshot.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Snapshot of the transcript generated during test execution. Can be either ConversationFlowPlaygroundSnapshot or MultiStatePromptPlaygroundSnapshot
    /// </summary>
    public sealed partial class TestCaseJobTranscriptSnapshot
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}