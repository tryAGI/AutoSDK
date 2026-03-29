//HintName: G.Models.VoicemailDetectionBackoffPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicemailDetectionBackoffPlan
    {
        /// <summary>
        /// This is the number of seconds to wait before starting the first retry attempt.<br/>
        /// Default Value: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startAtSeconds")]
        public double? StartAtSeconds { get; set; }

        /// <summary>
        /// This is the interval in seconds between retry attempts.<br/>
        /// Default Value: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequencySeconds")]
        public double? FrequencySeconds { get; set; }

        /// <summary>
        /// This is the maximum number of retry attempts before giving up.<br/>
        /// Default Value: 6
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxRetries")]
        public double? MaxRetries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailDetectionBackoffPlan" /> class.
        /// </summary>
        /// <param name="startAtSeconds">
        /// This is the number of seconds to wait before starting the first retry attempt.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="frequencySeconds">
        /// This is the interval in seconds between retry attempts.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="maxRetries">
        /// This is the maximum number of retry attempts before giving up.<br/>
        /// Default Value: 6
        /// </param>
        public VoicemailDetectionBackoffPlan(
            double? startAtSeconds,
            double? frequencySeconds,
            double? maxRetries)
        {
            this.StartAtSeconds = startAtSeconds;
            this.FrequencySeconds = frequencySeconds;
            this.MaxRetries = maxRetries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailDetectionBackoffPlan" /> class.
        /// </summary>
        public VoicemailDetectionBackoffPlan()
        {
        }
    }
}