//HintName: G.Models.OpenAPICreateOrganizationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPICreateOrganizationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("super_admin_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SuperAdminUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPICreateOrganizationRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="superAdminUserId"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAPICreateOrganizationRequest(
            string name,
            string superAdminUserId,
            string? description)
        {
            this.Description = description;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SuperAdminUserId = superAdminUserId ?? throw new global::System.ArgumentNullException(nameof(superAdminUserId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPICreateOrganizationRequest" /> class.
        /// </summary>
        public OpenAPICreateOrganizationRequest()
        {
        }
    }
}