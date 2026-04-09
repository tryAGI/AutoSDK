//HintName: G.Models.EditImageGetVirtualModelSceneVariant1Preset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Use a preset scene by name.
    /// </summary>
    public sealed partial class EditImageGetVirtualModelSceneVariant1Preset
    {
        /// <summary>
        /// Name of the preset scene.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EditImageGetVirtualModelSceneVariant1PresetNameJsonConverter))]
        public global::G.EditImageGetVirtualModelSceneVariant1PresetName Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelSceneVariant1Preset" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the preset scene.
        /// </param>
        public EditImageGetVirtualModelSceneVariant1Preset(
            global::G.EditImageGetVirtualModelSceneVariant1PresetName name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelSceneVariant1Preset" /> class.
        /// </summary>
        public EditImageGetVirtualModelSceneVariant1Preset()
        {
        }
    }
}