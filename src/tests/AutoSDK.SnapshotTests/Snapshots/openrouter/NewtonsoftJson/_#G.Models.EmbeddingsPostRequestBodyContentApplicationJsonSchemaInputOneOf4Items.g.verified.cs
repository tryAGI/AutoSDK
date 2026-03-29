//HintName: G.Models.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems> Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items" /> class.
        /// </summary>
        /// <param name="content"></param>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items(
            global::System.Collections.Generic.IList<global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems> content)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items" /> class.
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items()
        {
        }
    }
}