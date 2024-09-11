//HintName: G.Models.V2TemplateGenerateRequestDimension.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2TemplateGenerateRequestDimension
    {
        /// <summary>
        /// Example: 720
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public double Height { get; set; }

        /// <summary>
        /// Example: 1280
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}