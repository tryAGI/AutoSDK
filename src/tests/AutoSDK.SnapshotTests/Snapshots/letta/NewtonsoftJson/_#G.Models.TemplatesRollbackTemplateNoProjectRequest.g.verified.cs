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
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesRollbackTemplateNoProjectRequest" /> class.
        /// </summary>
        /// <param name="version">
        /// The target version to rollback to (e.g., "1", "2", "latest"). Cannot be "current" or "dev".
        /// </param>
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