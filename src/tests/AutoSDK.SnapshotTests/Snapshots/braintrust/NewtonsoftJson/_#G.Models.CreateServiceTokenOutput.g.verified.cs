//HintName: G.Models.CreateServiceTokenOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateServiceTokenOutput
    {
        /// <summary>
        /// Unique identifier for the service token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Date of service token creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Name of the service token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PreviewName { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the service token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_account_id")]
        public global::System.Guid? ServiceAccountId { get; set; }

        /// <summary>
        /// The service account email (not routable)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_account_email")]
        public string? ServiceAccountEmail { get; set; }

        /// <summary>
        /// The service account name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_account_name")]
        public string? ServiceAccountName { get; set; }

        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id")]
        public global::System.Guid? OrgId { get; set; }

        /// <summary>
        /// The raw service token. It will only be exposed this one time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServiceTokenOutput" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the service token
        /// </param>
        /// <param name="name">
        /// Name of the service token
        /// </param>
        /// <param name="previewName"></param>
        /// <param name="key">
        /// The raw service token. It will only be exposed this one time
        /// </param>
        /// <param name="created">
        /// Date of service token creation
        /// </param>
        /// <param name="serviceAccountId">
        /// Unique identifier for the service token
        /// </param>
        /// <param name="serviceAccountEmail">
        /// The service account email (not routable)
        /// </param>
        /// <param name="serviceAccountName">
        /// The service account name
        /// </param>
        /// <param name="orgId">
        /// Unique identifier for the organization
        /// </param>
        public CreateServiceTokenOutput(
            global::System.Guid id,
            string name,
            string previewName,
            string key,
            global::System.DateTime? created,
            global::System.Guid? serviceAccountId,
            string? serviceAccountEmail,
            string? serviceAccountName,
            global::System.Guid? orgId)
        {
            this.Id = id;
            this.Created = created;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PreviewName = previewName ?? throw new global::System.ArgumentNullException(nameof(previewName));
            this.ServiceAccountId = serviceAccountId;
            this.ServiceAccountEmail = serviceAccountEmail;
            this.ServiceAccountName = serviceAccountName;
            this.OrgId = orgId;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServiceTokenOutput" /> class.
        /// </summary>
        public CreateServiceTokenOutput()
        {
        }
    }
}