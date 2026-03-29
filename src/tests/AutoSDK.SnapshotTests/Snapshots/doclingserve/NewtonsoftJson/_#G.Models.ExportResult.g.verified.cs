//HintName: G.Models.ExportResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Container of all exported content.
    /// </summary>
    public sealed partial class ExportResult
    {
        /// <summary>
        /// Default Value: ExportResult
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExportDocumentResponse Content { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ExportResult" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="status"></param>
        /// <param name="kind">
        /// Default Value: ExportResult
        /// </param>
        /// <param name="errors">
        /// Default Value: []
        /// </param>
        /// <param name="timings">
        /// Default Value: {}
        /// </param>
        public ExportResult(
            global::G.ExportDocumentResponse content,
            global::G.ConversionStatus status,
            string? kind,
            global::System.Collections.Generic.IList<global::G.ErrorItem>? errors,
            global::System.Collections.Generic.Dictionary<string, global::G.ProfilingItem>? timings)
        {
            this.Kind = kind;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Status = status;
            this.Errors = errors;
            this.Timings = timings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportResult" /> class.
        /// </summary>
        public ExportResult()
        {
        }
    }
}