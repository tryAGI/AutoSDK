//HintName: G.Models.EditImageGetVirtualModelSceneVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditImageGetVirtualModelSceneVariant1
    {
        /// <summary>
        /// Use a preset scene by name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EditImageGetVirtualModelSceneVariant1Preset Preset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelSceneVariant1" /> class.
        /// </summary>
        /// <param name="preset">
        /// Use a preset scene by name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditImageGetVirtualModelSceneVariant1(
            global::G.EditImageGetVirtualModelSceneVariant1Preset preset)
        {
            this.Preset = preset ?? throw new global::System.ArgumentNullException(nameof(preset));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetVirtualModelSceneVariant1" /> class.
        /// </summary>
        public EditImageGetVirtualModelSceneVariant1()
        {
        }
    }
}