//HintName: G.Models.WorkspaceNameHolder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceNameHolder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_name")]
        public string? WorkspaceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceNameHolder" /> class.
        /// </summary>
        /// <param name="workspaceName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceNameHolder(
            string? workspaceName)
        {
            this.WorkspaceName = workspaceName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceNameHolder" /> class.
        /// </summary>
        public WorkspaceNameHolder()
        {
        }
    }
}