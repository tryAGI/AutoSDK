//HintName: G.Models.UtteranceMistranscribedImportantEntitiesDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UtteranceMistranscribedImportantEntitiesDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_transcript")]
        public string? OriginalTranscript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("corrected_transcript")]
        public string? CorrectedTranscript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceMistranscribedImportantEntitiesDetail" /> class.
        /// </summary>
        /// <param name="originalTranscript"></param>
        /// <param name="correctedTranscript"></param>
        public UtteranceMistranscribedImportantEntitiesDetail(
            string? originalTranscript,
            string? correctedTranscript)
        {
            this.OriginalTranscript = originalTranscript;
            this.CorrectedTranscript = correctedTranscript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceMistranscribedImportantEntitiesDetail" /> class.
        /// </summary>
        public UtteranceMistranscribedImportantEntitiesDetail()
        {
        }
    }
}