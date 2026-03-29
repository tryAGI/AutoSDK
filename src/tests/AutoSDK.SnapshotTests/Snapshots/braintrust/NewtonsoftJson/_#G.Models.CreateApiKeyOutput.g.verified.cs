//HintName: G.Models.CreateApiKeyOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiKeyOutput
    {
        /// <summary>
        /// Unique identifier for the api key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Date of api key creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Name of the api key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PreviewName { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// The user's email
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// Given name of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_given_name")]
        public string? UserGivenName { get; set; }

        /// <summary>
        /// Family name of the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_family_name")]
        public string? UserFamilyName { get; set; }

        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id")]
        public global::System.Guid? OrgId { get; set; }

        /// <summary>
        /// The raw API key. It will only be exposed this one time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyOutput" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the api key
        /// </param>
        /// <param name="name">
        /// Name of the api key
        /// </param>
        /// <param name="previewName"></param>
        /// <param name="key">
        /// The raw API key. It will only be exposed this one time
        /// </param>
        /// <param name="created">
        /// Date of api key creation
        /// </param>
        /// <param name="userId">
        /// Unique identifier for the user
        /// </param>
        /// <param name="userEmail">
        /// The user's email
        /// </param>
        /// <param name="userGivenName">
        /// Given name of the user
        /// </param>
        /// <param name="userFamilyName">
        /// Family name of the user
        /// </param>
        /// <param name="orgId">
        /// Unique identifier for the organization
        /// </param>
        public CreateApiKeyOutput(
            global::System.Guid id,
            string name,
            string previewName,
            string key,
            global::System.DateTime? created,
            global::System.Guid? userId,
            string? userEmail,
            string? userGivenName,
            string? userFamilyName,
            global::System.Guid? orgId)
        {
            this.Id = id;
            this.Created = created;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PreviewName = previewName ?? throw new global::System.ArgumentNullException(nameof(previewName));
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.UserGivenName = userGivenName;
            this.UserFamilyName = userFamilyName;
            this.OrgId = orgId;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyOutput" /> class.
        /// </summary>
        public CreateApiKeyOutput()
        {
        }
    }
}