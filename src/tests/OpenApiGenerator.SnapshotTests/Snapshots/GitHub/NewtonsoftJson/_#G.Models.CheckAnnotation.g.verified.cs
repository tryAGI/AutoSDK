//HintName: G.Models.CheckAnnotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Check Annotation
    /// </summary>
    public sealed partial class CheckAnnotation
    {
        /// <summary>
        /// <br/>Example: README.md
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_line", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartLine { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_line", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndLine { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_column", Required = global::Newtonsoft.Json.Required.Always)]
        public int? StartColumn { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_column", Required = global::Newtonsoft.Json.Required.Always)]
        public int? EndColumn { get; set; } = default!;

        /// <summary>
        /// <br/>Example: warning
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation_level", Required = global::Newtonsoft.Json.Required.Always)]
        public string? AnnotationLevel { get; set; } = default!;

        /// <summary>
        /// <br/>Example: Spell Checker
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Title { get; set; } = default!;

        /// <summary>
        /// <br/>Example: Check your spelling for 'banaas'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Message { get; set; } = default!;

        /// <summary>
        /// <br/>Example: Do you mean 'bananas' or 'banana'?
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("raw_details", Required = global::Newtonsoft.Json.Required.Always)]
        public string? RawDetails { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blob_href", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlobHref { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}