//HintName: G.Models.PatchedWorkspaceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ModelSerializer that takes additional arguments for<br/>
    /// "fields", "omit" and "expand" in order to<br/>
    /// control which fields are displayed, and whether to replace simple<br/>
    /// values with complex, nested serializations
    /// </summary>
    public sealed partial class PatchedWorkspaceRequest
    {
        /// <summary>
        /// Color
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Workspace description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Workspace is archived
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_archived")]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// Workspace is a personal user workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_personal")]
        public bool? IsPersonal { get; set; }

        /// <summary>
        /// Workspace Name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedWorkspaceRequest" /> class.
        /// </summary>
        /// <param name="color">
        /// Color
        /// </param>
        /// <param name="description">
        /// Workspace description
        /// </param>
        /// <param name="isArchived">
        /// Workspace is archived
        /// </param>
        /// <param name="isPersonal">
        /// Workspace is a personal user workspace
        /// </param>
        /// <param name="title">
        /// Workspace Name
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedWorkspaceRequest(
            string? color,
            string? description,
            bool? isArchived,
            bool? isPersonal,
            string? title)
        {
            this.Color = color;
            this.Description = description;
            this.IsArchived = isArchived;
            this.IsPersonal = isPersonal;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedWorkspaceRequest" /> class.
        /// </summary>
        public PatchedWorkspaceRequest()
        {
        }
    }
}