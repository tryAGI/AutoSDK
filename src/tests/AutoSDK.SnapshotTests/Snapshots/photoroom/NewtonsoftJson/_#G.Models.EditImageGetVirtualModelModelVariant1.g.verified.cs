//HintName: G.Models.EditImageGetVirtualModelModelVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditImageGetVirtualModelModelVariant1
    {
        /// <summary>
        /// Use a preset model by name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preset", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EditImageGetVirtualModelModelVariant1Preset Preset { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelModelVariant1" /> class.
        /// </summary>
        /// <param name="preset">
        /// Use a preset model by name.
        /// </param>
        public EditImageGetVirtualModelModelVariant1(
            global::G.EditImageGetVirtualModelModelVariant1Preset preset)
        {
            this.Preset = preset ?? throw new global::System.ArgumentNullException(nameof(preset));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelModelVariant1" /> class.
        /// </summary>
        public EditImageGetVirtualModelModelVariant1()
        {
        }
    }
}