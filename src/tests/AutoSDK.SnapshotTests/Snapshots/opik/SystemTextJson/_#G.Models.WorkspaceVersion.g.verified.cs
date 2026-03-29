//HintName: G.Models.WorkspaceVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Workspace version response.<br/>
    /// The opik_version field indicates which navigation mode the frontend should render:<br/>
    /// 'version_1' (legacy workspace-scoped) or 'version_2' (project-first).
    /// </summary>
    public sealed partial class WorkspaceVersion
    {
        /// <summary>
        /// The determined Opik navigation version for this workspace.<br/>
        /// 'version_1' = legacy workspace-scoped navigation,<br/>
        /// 'version_2' = new project-first navigation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opik_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WorkspaceVersionOpikVersionJsonConverter))]
        public global::G.WorkspaceVersionOpikVersion? OpikVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceVersion" /> class.
        /// </summary>
        /// <param name="opikVersion">
        /// The determined Opik navigation version for this workspace.<br/>
        /// 'version_1' = legacy workspace-scoped navigation,<br/>
        /// 'version_2' = new project-first navigation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceVersion(
            global::G.WorkspaceVersionOpikVersion? opikVersion)
        {
            this.OpikVersion = opikVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceVersion" /> class.
        /// </summary>
        public WorkspaceVersion()
        {
        }
    }
}