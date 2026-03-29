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
        [global::Newtonsoft.Json.JsonProperty("attributes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Attributes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SchemaUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanResource" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="schemaUrl"></param>
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