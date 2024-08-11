//HintName: G.Models.ValidationErrorSimple.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Validation Error Simple
    /// </summary>
    public sealed partial class ValidationErrorSimple
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentation_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DocumentationUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}