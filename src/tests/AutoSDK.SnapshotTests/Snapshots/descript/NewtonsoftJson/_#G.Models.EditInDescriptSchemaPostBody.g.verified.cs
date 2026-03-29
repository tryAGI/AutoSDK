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
        [global::Newtonsoft.Json.JsonProperty("partner_drive_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid PartnerDriveId { get; set; } = default!;

        /// <summary>
        /// The Project schema
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EditInDescriptSchemaPostBodyProjectSchema ProjectSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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