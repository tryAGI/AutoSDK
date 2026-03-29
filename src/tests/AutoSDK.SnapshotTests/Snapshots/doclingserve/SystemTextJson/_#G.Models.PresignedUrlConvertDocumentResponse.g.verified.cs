//HintName: G.Models.PresignedUrlConvertDocumentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PresignedUrlConvertDocumentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ProcessingTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_converted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumConverted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_succeeded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumSucceeded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumFailed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignedUrlConvertDocumentResponse" /> class.
        /// </summary>
        /// <param name="processingTime"></param>
        /// <param name="numConverted"></param>
        /// <param name="numSucceeded"></param>
        /// <param name="numFailed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresignedUrlConvertDocumentResponse(
            double processingTime,
            int numConverted,
            int numSucceeded,
            int numFailed)
        {
            this.ProcessingTime = processingTime;
            this.NumConverted = numConverted;
            this.NumSucceeded = numSucceeded;
            this.NumFailed = numFailed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignedUrlConvertDocumentResponse" /> class.
        /// </summary>
        public PresignedUrlConvertDocumentResponse()
        {
        }
    }
}