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
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("super_admin_user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SuperAdminUserId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPICreateOrganizationRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="superAdminUserId"></param>
        /// <param name="description"></param>
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