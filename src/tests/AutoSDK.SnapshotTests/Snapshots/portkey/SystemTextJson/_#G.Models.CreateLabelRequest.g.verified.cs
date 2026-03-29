//HintName: G.Models.CreateLabelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLabelRequest
    {
        /// <summary>
        /// ID of the organisation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// ID or slug of the workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Name of the label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Color code for the label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_code")]
        public string? ColorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLabelRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the label
        /// </param>
        /// <param name="organisationId">
        /// ID of the organisation
        /// </param>
        /// <param name="workspaceId">
        /// ID or slug of the workspace
        /// </param>
        /// <param name="description">
        /// Description of the label
        /// </param>
        /// <param name="colorCode">
        /// Color code for the label
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLabelRequest(
            string name,
            global::System.Guid? organisationId,
            string? workspaceId,
            string? description,
            string? colorCode)
        {
            this.OrganisationId = organisationId;
            this.WorkspaceId = workspaceId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ColorCode = colorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLabelRequest" /> class.
        /// </summary>
        public CreateLabelRequest()
        {
        }
    }
}