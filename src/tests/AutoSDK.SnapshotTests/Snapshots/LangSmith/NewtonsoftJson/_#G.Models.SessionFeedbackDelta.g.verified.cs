//HintName: G.Models.SessionFeedbackDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of feedback keys with number of improvements and regressions for each.
    /// </summary>
    public sealed partial class SessionFeedbackDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_deltas", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.FeedbackDelta> FeedbackDeltas { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}