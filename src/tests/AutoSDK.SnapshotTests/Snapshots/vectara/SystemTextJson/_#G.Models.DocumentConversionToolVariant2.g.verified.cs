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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "document_conversion";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentConversionToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `document_conversion`.<br/>
        /// Default Value: document_conversion<br/>
        /// Example: document_conversion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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