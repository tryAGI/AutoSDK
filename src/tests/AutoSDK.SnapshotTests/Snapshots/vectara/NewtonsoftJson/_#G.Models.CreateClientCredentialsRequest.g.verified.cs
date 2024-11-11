//HintName: G.Models.CreateClientCredentialsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create an App Client which allows you to call Vectara APIs using OAuth 2.0 client credentials.
    /// </summary>
    public sealed partial class CreateClientCredentialsRequest
    {
        /// <summary>
        /// Name of the client credentials.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the client credentials.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// This will always be the value `client_credentials`.<br/>
        /// Default Value: client_credentials
        /// </summary>
        /// <default>"client_credentials"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// API roles that the client credentials will have.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_roles")]
        public global::System.Collections.Generic.IList<global::G.ApiRole>? ApiRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClientCredentialsRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the client credentials.
        /// </param>
        /// <param name="description">
        /// Description of the client credentials.
        /// </param>
        /// <param name="type">
        /// This will always be the value `client_credentials`.<br/>
        /// Default Value: client_credentials
        /// </param>
        /// <param name="apiRoles">
        /// API roles that the client credentials will have.
        /// </param>
        public CreateClientCredentialsRequest(
            string name,
            string type,
            string? description,
            global::System.Collections.Generic.IList<global::G.ApiRole>? apiRoles)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Description = description;
            this.ApiRoles = apiRoles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClientCredentialsRequest" /> class.
        /// </summary>
        public CreateClientCredentialsRequest()
        {
        }
    }
}