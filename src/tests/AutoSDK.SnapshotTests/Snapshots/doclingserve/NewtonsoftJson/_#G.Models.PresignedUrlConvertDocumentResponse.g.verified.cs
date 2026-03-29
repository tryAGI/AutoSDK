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
        [global::Newtonsoft.Json.JsonProperty("processing_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double ProcessingTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_converted", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumConverted { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_succeeded", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumSucceeded { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_failed", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumFailed { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresignedUrlConvertDocumentResponse" /> class.
        /// </summary>
        /// <param name="processingTime"></param>
        /// <param name="numConverted"></param>
        /// <param name="numSucceeded"></param>
        /// <param name="numFailed"></param>
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