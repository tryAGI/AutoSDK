//HintName: G.Models.UpdateUserExtensionsBodyData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The extensions to update. The `data` field is a dictionary of extension types. The dictionary’s possible keys are: panel, overlay, or component. The key’s value is a dictionary of extensions.  <br/>
    ///   <br/>
    /// For the extension’s dictionary, the key is a sequential number beginning with 1\. For panel and overlay extensions, the key’s value is an object that contains the following fields: `active` (true/false), `id` (the extension’s ID), and `version` (the extension’s version).  <br/>
    ///   <br/>
    /// For component extensions, the key’s value includes the above fields plus the `x` and `y` fields, which identify the coordinate where the extension is placed.
    /// </summary>
    public sealed partial class UpdateUserExtensionsBodyData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("panel")]
        public global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionPanelUpdate>? Panel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlay")]
        public global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionOverlayUpdate>? Overlay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component")]
        public global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionComponentUpdate>? Component { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserExtensionsBodyData" /> class.
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="overlay"></param>
        /// <param name="component"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateUserExtensionsBodyData(
            global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionPanelUpdate>? panel,
            global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionOverlayUpdate>? overlay,
            global::System.Collections.Generic.Dictionary<string, global::G.UserExtensionComponentUpdate>? component)
        {
            this.Panel = panel;
            this.Overlay = overlay;
            this.Component = component;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserExtensionsBodyData" /> class.
        /// </summary>
        public UpdateUserExtensionsBodyData()
        {
        }
    }
}