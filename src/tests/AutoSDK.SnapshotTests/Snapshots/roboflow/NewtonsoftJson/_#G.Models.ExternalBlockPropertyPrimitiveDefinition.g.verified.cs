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
        [global::Newtonsoft.Json.JsonProperty("manifest_type_identifier", Required = global::Newtonsoft.Json.Required.Always)]
        public string ManifestTypeIdentifier { get; set; } = default!;

        /// <summary>
        /// Name of specific property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("property_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PropertyName { get; set; } = default!;

        /// <summary>
        /// Description for specific property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("property_description", Required = global::Newtonsoft.Json.Required.Always)]
        public string PropertyDescription { get; set; } = default!;

        /// <summary>
        /// Pythonic type annotation for property
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type_annotation", Required = global::Newtonsoft.Json.Required.Always)]
        public string TypeAnnotation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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