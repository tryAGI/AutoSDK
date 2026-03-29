//HintName: G.Models.PipelinesPreviewPipelineRequestProducerConfigVariant1Data.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesPreviewPipelineRequestProducerConfigVariant1Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PipelinesPreviewPipelineRequestProducerConfigVariant1DataChannel> Channels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_messages_per_poll")]
        public double? MaxMessagesPerPoll { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesPreviewPipelineRequestProducerConfigVariant1Data" /> class.
        /// </summary>
        /// <param name="channels"></param>
        /// <param name="maxMessagesPerPoll"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinesPreviewPipelineRequestProducerConfigVariant1Data(
            global::System.Collections.Generic.IList<global::G.PipelinesPreviewPipelineRequestProducerConfigVariant1DataChannel> channels,
            double? maxMessagesPerPoll)
        {
            this.Channels = channels ?? throw new global::System.ArgumentNullException(nameof(channels));
            this.MaxMessagesPerPoll = maxMessagesPerPoll;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesPreviewPipelineRequestProducerConfigVariant1Data" /> class.
        /// </summary>
        public PipelinesPreviewPipelineRequestProducerConfigVariant1Data()
        {
        }
    }
}