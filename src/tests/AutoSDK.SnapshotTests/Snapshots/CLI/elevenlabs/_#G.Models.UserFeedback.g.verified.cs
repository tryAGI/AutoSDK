//HintName: G.Models.UserFeedback.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserFeedback
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UserFeedbackScoreJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UserFeedbackScore Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_in_call_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TimeInCallSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFeedback" /> class.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="timeInCallSecs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserFeedback(
            global::G.UserFeedbackScore score,
            int timeInCallSecs)
        {
            this.Score = score;
            this.TimeInCallSecs = timeInCallSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFeedback" /> class.
        /// </summary>
        public UserFeedback()
        {
        }
    }
}