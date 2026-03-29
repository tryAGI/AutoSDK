//HintName: G.Models.PatchedSessionTimeoutPolicyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedSessionTimeoutPolicyRequest
    {
        /// <summary>
        /// Number of minutes that a session can be active before needing to re-login
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_session_age")]
        public int? MaxSessionAge { get; set; }

        /// <summary>
        /// Number of minutes that a session stays active without any activity
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_time_between_activity")]
        public int? MaxTimeBetweenActivity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedSessionTimeoutPolicyRequest" /> class.
        /// </summary>
        /// <param name="maxSessionAge">
        /// Number of minutes that a session can be active before needing to re-login
        /// </param>
        /// <param name="maxTimeBetweenActivity">
        /// Number of minutes that a session stays active without any activity
        /// </param>
        public PatchedSessionTimeoutPolicyRequest(
            int? maxSessionAge,
            int? maxTimeBetweenActivity)
        {
            this.MaxSessionAge = maxSessionAge;
            this.MaxTimeBetweenActivity = maxTimeBetweenActivity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedSessionTimeoutPolicyRequest" /> class.
        /// </summary>
        public PatchedSessionTimeoutPolicyRequest()
        {
        }
    }
}