//HintName: G.Models.V2TemplateGenerateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2TemplateGenerateRequest
    {
        /// <summary>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        public bool Caption { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public global::G.V2TemplateGenerateRequestDimension? Dimension { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test")]
        public bool Test { get; set; }

        /// <summary>
        /// Example: New Video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::G.V2TemplateGenerateRequestVariables? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}