//HintName: G.Models.ReturnTimeoutSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnTimeoutSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_secs")]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnTimeoutSpec" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="durationSecs"></param>
        public ReturnTimeoutSpec(
            bool? enabled,
            int? durationSecs)
        {
            this.Enabled = enabled;
            this.DurationSecs = durationSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnTimeoutSpec" /> class.
        /// </summary>
        public ReturnTimeoutSpec()
        {
        }
    }
}