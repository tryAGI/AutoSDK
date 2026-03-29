//HintName: G.Models.PostedTimeoutSpecsInactivity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedTimeoutSpecsInactivity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedTimeoutSpecsInactivity" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="durationSecs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostedTimeoutSpecsInactivity(
            bool? enabled,
            int? durationSecs)
        {
            this.Enabled = enabled;
            this.DurationSecs = durationSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedTimeoutSpecsInactivity" /> class.
        /// </summary>
        public PostedTimeoutSpecsInactivity()
        {
        }
    }
}