//HintName: G.Models.EditInDescriptSchemaPostBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditInDescriptSchemaPostBody
    {
        /// <summary>
        /// The drive id associated with the auth token.<br/>
        /// Example: aa3b2d8d-e5ca-41c2-8801-683328293fb9
        /// </summary>
        /// <example>aa3b2d8d-e5ca-41c2-8801-683328293fb9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("partner_drive_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PartnerDriveId { get; set; }

        /// <summary>
        /// The Project schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EditInDescriptSchemaPostBodyProjectSchema ProjectSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditInDescriptSchemaPostBody" /> class.
        /// </summary>
        /// <param name="partnerDriveId">
        /// The drive id associated with the auth token.<br/>
        /// Example: aa3b2d8d-e5ca-41c2-8801-683328293fb9
        /// </param>
        /// <param name="projectSchema">
        /// The Project schema
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditInDescriptSchemaPostBody(
            global::System.Guid partnerDriveId,
            global::G.EditInDescriptSchemaPostBodyProjectSchema projectSchema)
        {
            this.PartnerDriveId = partnerDriveId;
            this.ProjectSchema = projectSchema ?? throw new global::System.ArgumentNullException(nameof(projectSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditInDescriptSchemaPostBody" /> class.
        /// </summary>
        public EditInDescriptSchemaPostBody()
        {
        }
    }
}