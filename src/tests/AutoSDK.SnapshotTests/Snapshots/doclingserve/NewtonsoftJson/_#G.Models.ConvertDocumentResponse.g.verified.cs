//HintName: G.Models.ConvertDocumentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvertDocumentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExportDocumentResponse Document { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConversionStatus Status { get; set; } = default!;

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public global::System.Collections.Generic.IList<global::G.ErrorItem>? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processing_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double ProcessingTime { get; set; } = default!;

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timings")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ProfilingItem>? Timings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentResponse" /> class.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="status"></param>
        /// <param name="processingTime"></param>
        /// <param name="errors">
        /// Default Value: []
        /// </param>
        /// <param name="timings">
        /// Default Value: {}
        /// </param>
        public ConvertDocumentResponse(
            global::G.ExportDocumentResponse document,
            global::G.ConversionStatus status,
            double processingTime,
            global::System.Collections.Generic.IList<global::G.ErrorItem>? errors,
            global::System.Collections.Generic.Dictionary<string, global::G.ProfilingItem>? timings)
        {
            this.Document = document ?? throw new global::System.ArgumentNullException(nameof(document));
            this.Status = status;
            this.Errors = errors;
            this.ProcessingTime = processingTime;
            this.Timings = timings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentResponse" /> class.
        /// </summary>
        public ConvertDocumentResponse()
        {
        }
    }
}