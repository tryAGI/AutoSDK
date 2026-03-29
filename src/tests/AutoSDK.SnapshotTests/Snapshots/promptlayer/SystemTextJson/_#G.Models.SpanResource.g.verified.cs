//HintName: G.Models.SpanResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanResource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SchemaUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanResource" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="schemaUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpanResource(
            global::System.Collections.Generic.Dictionary<string, string> attributes,
            string schemaUrl)
        {
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.SchemaUrl = schemaUrl ?? throw new global::System.ArgumentNullException(nameof(schemaUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanResource" /> class.
        /// </summary>
        public SpanResource()
        {
        }
    }
}