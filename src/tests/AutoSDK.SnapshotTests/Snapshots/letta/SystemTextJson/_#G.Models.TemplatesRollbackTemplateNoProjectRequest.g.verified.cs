//HintName: G.Models.TemplatesRollbackTemplateNoProjectRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesRollbackTemplateNoProjectRequest
    {
        /// <summary>
        /// The target version to rollback to (e.g., "1", "2", "latest"). Cannot be "current" or "dev".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesRollbackTemplateNoProjectRequest" /> class.
        /// </summary>
        /// <param name="version">
        /// The target version to rollback to (e.g., "1", "2", "latest"). Cannot be "current" or "dev".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesRollbackTemplateNoProjectRequest(
            string version)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesRollbackTemplateNoProjectRequest" /> class.
        /// </summary>
        public TemplatesRollbackTemplateNoProjectRequest()
        {
        }
    }
}