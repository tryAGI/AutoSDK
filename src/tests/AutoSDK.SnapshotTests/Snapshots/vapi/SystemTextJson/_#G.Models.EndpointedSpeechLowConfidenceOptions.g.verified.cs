//HintName: G.Models.EndpointedSpeechLowConfidenceOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndpointedSpeechLowConfidenceOptions
    {
        /// <summary>
        /// This is the minimum confidence threshold.<br/>
        /// Transcripts with confidence below this value will be discarded.<br/>
        /// @default confidenceMax - 0.2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidenceMin")]
        public double? ConfidenceMin { get; set; }

        /// <summary>
        /// This is the maximum confidence threshold.<br/>
        /// Transcripts with confidence at or above this value will be processed normally.<br/>
        /// @default transcriber's confidenceThreshold
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidenceMax")]
        public double? ConfidenceMax { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointedSpeechLowConfidenceOptions" /> class.
        /// </summary>
        /// <param name="confidenceMin">
        /// This is the minimum confidence threshold.<br/>
        /// Transcripts with confidence below this value will be discarded.<br/>
        /// @default confidenceMax - 0.2
        /// </param>
        /// <param name="confidenceMax">
        /// This is the maximum confidence threshold.<br/>
        /// Transcripts with confidence at or above this value will be processed normally.<br/>
        /// @default transcriber's confidenceThreshold
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointedSpeechLowConfidenceOptions(
            double? confidenceMin,
            double? confidenceMax)
        {
            this.ConfidenceMin = confidenceMin;
            this.ConfidenceMax = confidenceMax;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointedSpeechLowConfidenceOptions" /> class.
        /// </summary>
        public EndpointedSpeechLowConfidenceOptions()
        {
        }
    }
}