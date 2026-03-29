//HintName: G.Models.AgentRequestUserDtmfOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentRequestUserDtmfOptions
    {
        /// <summary>
        /// The maximum number of digits allowed in the user's DTMF (Dual-Tone Multi-Frequency) input per turn. Once this limit is reached, the input is considered complete and a response will be generated immediately.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digit_limit")]
        public double? DigitLimit { get; set; }

        /// <summary>
        /// A single key that signals the end of DTMF input. Acceptable values include any digit (0-9), the pound/hash symbol (#), or the asterisk (*).<br/>
        /// Example: #
        /// </summary>
        /// <example>#</example>
        [global::Newtonsoft.Json.JsonProperty("termination_key")]
        public string? TerminationKey { get; set; }

        /// <summary>
        /// The time (in milliseconds) to wait for user DTMF input before timing out. The timer resets with each digit received.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestUserDtmfOptions" /> class.
        /// </summary>
        /// <param name="digitLimit">
        /// The maximum number of digits allowed in the user's DTMF (Dual-Tone Multi-Frequency) input per turn. Once this limit is reached, the input is considered complete and a response will be generated immediately.
        /// </param>
        /// <param name="terminationKey">
        /// A single key that signals the end of DTMF input. Acceptable values include any digit (0-9), the pound/hash symbol (#), or the asterisk (*).<br/>
        /// Example: #
        /// </param>
        /// <param name="timeoutMs">
        /// The time (in milliseconds) to wait for user DTMF input before timing out. The timer resets with each digit received.
        /// </param>
        public AgentRequestUserDtmfOptions(
            double? digitLimit,
            string? terminationKey,
            int? timeoutMs)
        {
            this.DigitLimit = digitLimit;
            this.TerminationKey = terminationKey;
            this.TimeoutMs = timeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequestUserDtmfOptions" /> class.
        /// </summary>
        public AgentRequestUserDtmfOptions()
        {
        }
    }
}