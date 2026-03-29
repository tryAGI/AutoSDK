//HintName: G.Models.ProjectDuplicateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectDuplicateRequest
    {
        /// <summary>
        /// Project Description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// What to Duplicate (Project configuration only / Project configuration and tasks)<br/>
        /// * `settings` - Only settings<br/>
        /// * `settings,data` - Settings and tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModeEnum Mode { get; set; }

        /// <summary>
        /// Project Name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Destination Workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Workspace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDuplicateRequest" /> class.
        /// </summary>
        /// <param name="mode">
        /// What to Duplicate (Project configuration only / Project configuration and tasks)<br/>
        /// * `settings` - Only settings<br/>
        /// * `settings,data` - Settings and tasks
        /// </param>
        /// <param name="title">
        /// Project Name
        /// </param>
        /// <param name="workspace">
        /// Destination Workspace
        /// </param>
        /// <param name="description">
        /// Project Description
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectDuplicateRequest(
            global::G.ModeEnum mode,
            string title,
            int workspace,
            string? description)
        {
            this.Description = description;
            this.Mode = mode;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Workspace = workspace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDuplicateRequest" /> class.
        /// </summary>
        public ProjectDuplicateRequest()
        {
        }
    }
}