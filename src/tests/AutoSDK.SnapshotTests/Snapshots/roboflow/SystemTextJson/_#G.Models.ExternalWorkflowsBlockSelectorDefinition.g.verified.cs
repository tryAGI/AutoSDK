//HintName: G.Models.ExternalWorkflowsBlockSelectorDefinition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExternalWorkflowsBlockSelectorDefinition
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
        /// Defines to what type of object (step_output, parameter, etc) reference may be pointing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compatible_element")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompatibleElement { get; set; }

        /// <summary>
        /// Boolean flag defining if list of references will be accepted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_list_element")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsListElement { get; set; }

        /// <summary>
        /// Boolean flag defining if dict of references will be accepted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_dict_element")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDictElement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalWorkflowsBlockSelectorDefinition" /> class.
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
        /// <param name="compatibleElement">
        /// Defines to what type of object (step_output, parameter, etc) reference may be pointing
        /// </param>
        /// <param name="isListElement">
        /// Boolean flag defining if list of references will be accepted
        /// </param>
        /// <param name="isDictElement">
        /// Boolean flag defining if dict of references will be accepted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalWorkflowsBlockSelectorDefinition(
            string manifestTypeIdentifier,
            string propertyName,
            string propertyDescription,
            string compatibleElement,
            bool isListElement,
            bool isDictElement)
        {
            this.ManifestTypeIdentifier = manifestTypeIdentifier ?? throw new global::System.ArgumentNullException(nameof(manifestTypeIdentifier));
            this.PropertyName = propertyName ?? throw new global::System.ArgumentNullException(nameof(propertyName));
            this.PropertyDescription = propertyDescription ?? throw new global::System.ArgumentNullException(nameof(propertyDescription));
            this.CompatibleElement = compatibleElement ?? throw new global::System.ArgumentNullException(nameof(compatibleElement));
            this.IsListElement = isListElement;
            this.IsDictElement = isDictElement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalWorkflowsBlockSelectorDefinition" /> class.
        /// </summary>
        public ExternalWorkflowsBlockSelectorDefinition()
        {
        }
    }
}