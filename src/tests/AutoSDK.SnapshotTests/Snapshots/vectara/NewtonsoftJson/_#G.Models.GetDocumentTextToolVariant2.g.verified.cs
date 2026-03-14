//HintName: G.Models.GetDocumentTextToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDocumentTextToolVariant2
    {
        /// <summary>
        /// This should always be `get_document_text`.<br/>
        /// Default Value: get_document_text<br/>
        /// Example: get_document_text
        /// </summary>
        /// <default>"get_document_text"</default>
        /// <example>get_document_text</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentTextToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `get_document_text`.<br/>
        /// Default Value: get_document_text<br/>
        /// Example: get_document_text
        /// </param>
        public GetDocumentTextToolVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentTextToolVariant2" /> class.
        /// </summary>
        public GetDocumentTextToolVariant2()
        {
        }
    }
}