//HintName: G.Models.EditImageGetVirtualModelModelVariant1Preset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Use a preset model by name.
    /// </summary>
    public sealed partial class EditImageGetVirtualModelModelVariant1Preset
    {
        /// <summary>
        /// Name of the preset model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EditImageGetVirtualModelModelVariant1PresetNameJsonConverter))]
        public global::G.EditImageGetVirtualModelModelVariant1PresetName Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelModelVariant1Preset" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the preset model.
        /// </param>
        public EditImageGetVirtualModelModelVariant1Preset(
            global::G.EditImageGetVirtualModelModelVariant1PresetName name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelModelVariant1Preset" /> class.
        /// </summary>
        public EditImageGetVirtualModelModelVariant1Preset()
        {
        }
    }
}