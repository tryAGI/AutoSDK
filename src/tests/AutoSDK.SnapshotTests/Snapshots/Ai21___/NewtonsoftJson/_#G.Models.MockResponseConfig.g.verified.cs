//HintName: G.Models.MockResponseConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MockResponseConfig
    {
        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_delay_seconds")]
        public double? ResponseDelaySeconds { get; set; }

        /// <summary>
        /// Default Value: 0.1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_response_delay_between_deltas_seconds")]
        public double? StreamResponseDelayBetweenDeltasSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MockResponseConfig" /> class.
        /// </summary>
        /// <param name="responseDelaySeconds">
        /// Default Value: 1
        /// </param>
        /// <param name="streamResponseDelayBetweenDeltasSeconds">
        /// Default Value: 0.1
        /// </param>
        public MockResponseConfig(
            double? responseDelaySeconds,
            double? streamResponseDelayBetweenDeltasSeconds)
        {
            this.ResponseDelaySeconds = responseDelaySeconds;
            this.StreamResponseDelayBetweenDeltasSeconds = streamResponseDelayBetweenDeltasSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MockResponseConfig" /> class.
        /// </summary>
        public MockResponseConfig()
        {
        }
    }
}