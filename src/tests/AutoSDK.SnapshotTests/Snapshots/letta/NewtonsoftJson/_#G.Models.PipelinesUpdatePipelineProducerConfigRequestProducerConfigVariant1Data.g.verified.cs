//HintName: G.Models.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Data.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1DataChannel> Channels { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_messages_per_poll")]
        public double? MaxMessagesPerPoll { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Data" /> class.
        /// </summary>
        /// <param name="channels"></param>
        /// <param name="maxMessagesPerPoll"></param>
        public PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Data(
            global::System.Collections.Generic.IList<global::G.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1DataChannel> channels,
            double? maxMessagesPerPoll)
        {
            this.Channels = channels ?? throw new global::System.ArgumentNullException(nameof(channels));
            this.MaxMessagesPerPoll = maxMessagesPerPoll;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Data" /> class.
        /// </summary>
        public PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Data()
        {
        }
    }
}