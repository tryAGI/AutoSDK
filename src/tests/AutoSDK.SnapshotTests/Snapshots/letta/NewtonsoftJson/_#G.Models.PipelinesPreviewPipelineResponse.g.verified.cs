//HintName: G.Models.PipelinesPreviewPipelineResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesPreviewPipelineResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sampleMessages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> SampleMessages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messageCount", Required = global::Newtonsoft.Json.Required.Always)]
        public double MessageCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesPreviewPipelineResponse" /> class.
        /// </summary>
        /// <param name="sampleMessages"></param>
        /// <param name="messageCount"></param>
        public PipelinesPreviewPipelineResponse(
            global::System.Collections.Generic.IList<string> sampleMessages,
            double messageCount)
        {
            this.SampleMessages = sampleMessages ?? throw new global::System.ArgumentNullException(nameof(sampleMessages));
            this.MessageCount = messageCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesPreviewPipelineResponse" /> class.
        /// </summary>
        public PipelinesPreviewPipelineResponse()
        {
        }
    }
}