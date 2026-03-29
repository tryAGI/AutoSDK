//HintName: G.Models.PatchProjectSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Project settings. Patch operations replace all settings, so make sure you include all settings you want to keep.
    /// </summary>
    public sealed partial class PatchProjectSettings
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}