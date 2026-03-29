//HintName: G.Models.CreateOrganizationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationResponse
    {
        /// <summary>
        /// Example: Organization created successfully.
        /// </summary>
        /// <example>Organization created successfully.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Unique identifier for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public global::System.Guid? OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Organization created successfully.
        /// </param>
        /// <param name="orgId">
        /// Unique identifier for the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationResponse(
            string? message,
            global::System.Guid? orgId)
        {
            this.Message = message;
            this.OrgId = orgId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationResponse" /> class.
        /// </summary>
        public CreateOrganizationResponse()
        {
        }
    }
}