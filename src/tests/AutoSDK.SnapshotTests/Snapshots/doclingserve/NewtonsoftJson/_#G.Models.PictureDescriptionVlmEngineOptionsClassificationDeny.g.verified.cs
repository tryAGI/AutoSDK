//HintName: G.Models.PictureDescriptionVlmEngineOptionsClassificationDeny.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of picture classification labels to exclude from description. Pictures classified with these labels will be skipped. If None, no picture types are denied unless not in allow list. Use to exclude unwanted image types (e.g., decorative images, logos).
    /// </summary>
    public sealed partial class PictureDescriptionVlmEngineOptionsClassificationDeny
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}