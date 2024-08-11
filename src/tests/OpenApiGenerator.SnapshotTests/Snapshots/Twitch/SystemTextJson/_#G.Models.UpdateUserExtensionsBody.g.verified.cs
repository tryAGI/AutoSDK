//HintName: G.Models.UpdateUserExtensionsBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateUserExtensionsBody
    {
        /// <summary>
        /// The extensions to update. The `data` field is a dictionary of extension types. The dictionary’s possible keys are: panel, overlay, or component. The key’s value is a dictionary of extensions.  <br/>
        ///   <br/>
        /// For the extension’s dictionary, the key is a sequential number beginning with 1\. For panel and overlay extensions, the key’s value is an object that contains the following fields: `active` (true/false), `id` (the extension’s ID), and `version` (the extension’s version).  <br/>
        ///   <br/>
        /// For component extensions, the key’s value includes the above fields plus the `x` and `y` fields, which identify the coordinate where the extension is placed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UpdateUserExtensionsBodyData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}