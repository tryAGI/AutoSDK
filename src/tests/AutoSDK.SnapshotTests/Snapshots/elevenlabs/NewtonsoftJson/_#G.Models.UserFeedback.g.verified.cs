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
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UserFeedbackScore Score { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time_in_call_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int TimeInCallSecs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserFeedback" /> class.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="timeInCallSecs"></param>
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