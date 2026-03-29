//HintName: G.Models.SessionTimeoutPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionTimeoutPolicy
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Number of minutes that a session can be active before needing to re-login
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_session_age")]
        public int? MaxSessionAge { get; set; }

        /// <summary>
        /// Number of minutes that a session stays active without any activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_time_between_activity")]
        public int? MaxTimeBetweenActivity { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionTimeoutPolicy" /> class.
        /// </summary>
        /// <param name="maxSessionAge">
        /// Number of minutes that a session can be active before needing to re-login
        /// </param>
        /// <param name="maxTimeBetweenActivity">
        /// Number of minutes that a session stays active without any activity
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionTimeoutPolicy(
            int? maxSessionAge,
            int? maxTimeBetweenActivity,
            global::System.DateTime createdAt = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.CreatedAt = createdAt;
            this.MaxSessionAge = maxSessionAge;
            this.MaxTimeBetweenActivity = maxTimeBetweenActivity;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionTimeoutPolicy" /> class.
        /// </summary>
        public SessionTimeoutPolicy()
        {
        }
    }
}