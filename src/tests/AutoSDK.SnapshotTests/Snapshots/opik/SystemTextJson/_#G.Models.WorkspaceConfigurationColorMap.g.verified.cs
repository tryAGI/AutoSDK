//HintName: G.Models.WorkspaceConfigurationColorMap.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Workspace-level color map. Maps label names to hex color values (e.g. #FF0000). Max 10000 entries.
    /// </summary>
    public sealed partial class WorkspaceConfigurationColorMap
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}