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
        /// Defines to what type of object (step_output, parameter, etc) reference may be pointing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compatible_element", Required = global::Newtonsoft.Json.Required.Always)]
        public string CompatibleElement { get; set; } = default!;

        /// <summary>
        /// Boolean flag defining if list of references will be accepted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_list_element", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsListElement { get; set; } = default!;

        /// <summary>
        /// Boolean flag defining if dict of references will be accepted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_dict_element", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsDictElement { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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