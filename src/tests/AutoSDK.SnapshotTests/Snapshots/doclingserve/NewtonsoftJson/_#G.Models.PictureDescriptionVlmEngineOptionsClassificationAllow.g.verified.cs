//HintName: G.Models.PictureDescriptionVlmEngineOptionsClassificationAllow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of picture classification labels to allow for description. Only pictures classified with these labels will be processed. If None, all picture types are allowed unless explicitly denied. Use to focus description on specific image types (e.g., diagrams, charts).
    /// </summary>
    public sealed partial class PictureDescriptionVlmEngineOptionsClassificationAllow
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}