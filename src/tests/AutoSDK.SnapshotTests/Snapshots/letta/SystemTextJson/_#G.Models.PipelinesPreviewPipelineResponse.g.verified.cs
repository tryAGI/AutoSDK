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
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleMessages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SampleMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MessageCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesPreviewPipelineResponse" /> class.
        /// </summary>
        /// <param name="sampleMessages"></param>
        /// <param name="messageCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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