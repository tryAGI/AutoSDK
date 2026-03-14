//HintName: G.Models.DocumentConversionToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentConversionToolVariant2
    {
        /// <summary>
        /// This should always be `document_conversion`.<br/>
        /// Default Value: document_conversion<br/>
        /// Example: document_conversion
        /// </summary>
        /// <default>"document_conversion"</default>
        /// <example>document_conversion</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentConversionToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `document_conversion`.<br/>
        /// Default Value: document_conversion<br/>
        /// Example: document_conversion
        /// </param>
        public DocumentConversionToolVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentConversionToolVariant2" /> class.
        /// </summary>
        public DocumentConversionToolVariant2()
        {
        }
    }
}