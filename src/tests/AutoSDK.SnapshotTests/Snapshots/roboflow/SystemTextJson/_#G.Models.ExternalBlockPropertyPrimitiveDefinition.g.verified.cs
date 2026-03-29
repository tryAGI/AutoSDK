//HintName: G.Models.ExternalBlockPropertyPrimitiveDefinition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExternalBlockPropertyPrimitiveDefinition
    {
        /// <summary>
        /// Identifier of block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_type_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ManifestTypeIdentifier { get; set; }

        /// <summary>
        /// Name of specific property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PropertyName { get; set; }

        /// <summary>
        /// Description for specific property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PropertyDescription { get; set; }

        /// <summary>
        /// Pythonic type annotation for property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_annotation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TypeAnnotation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalBlockPropertyPrimitiveDefinition" /> class.
        /// </summary>
        /// <param name="manifestTypeIdentifier">
        /// Identifier of block
        /// </param>
        /// <param name="propertyName">
        /// Name of specific property
        /// </param>
        /// <param name="propertyDescription">
        /// Description for specific property
        /// </param>
        /// <param name="typeAnnotation">
        /// Pythonic type annotation for property
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalBlockPropertyPrimitiveDefinition(
            string manifestTypeIdentifier,
            string propertyName,
            string propertyDescription,
            string typeAnnotation)
        {
            this.ManifestTypeIdentifier = manifestTypeIdentifier ?? throw new global::System.ArgumentNullException(nameof(manifestTypeIdentifier));
            this.PropertyName = propertyName ?? throw new global::System.ArgumentNullException(nameof(propertyName));
            this.PropertyDescription = propertyDescription ?? throw new global::System.ArgumentNullException(nameof(propertyDescription));
            this.TypeAnnotation = typeAnnotation ?? throw new global::System.ArgumentNullException(nameof(typeAnnotation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalBlockPropertyPrimitiveDefinition" /> class.
        /// </summary>
        public ExternalBlockPropertyPrimitiveDefinition()
        {
        }
    }
}