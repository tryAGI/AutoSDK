//HintName: G.Models.AppClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClient
    {
        /// <summary>
        /// The Vectara App Client ID. This ID is not used during an OAuth<br/>
        /// flow.  However, the ID used within the Vectara API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The human-readable name of the App Client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the App Client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The client ID used with the OAuth flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// The client secret used in API requests.  The secret should be kept secure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// The API roles attached to the App Client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_roles")]
        public global::System.Collections.Generic.IList<global::G.ApiRole>? ApiRoles { get; set; }

        /// <summary>
        /// What actions a principal can take on the Vectara platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_policy")]
        public global::G.ApiPolicy? ApiPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClient" /> class.
        /// </summary>
        /// <param name="id">
        /// The Vectara App Client ID. This ID is not used during an OAuth<br/>
        /// flow.  However, the ID used within the Vectara API.
        /// </param>
        /// <param name="name">
        /// The human-readable name of the App Client.
        /// </param>
        /// <param name="description">
        /// Description of the App Client.
        /// </param>
        /// <param name="clientId">
        /// The client ID used with the OAuth flow.
        /// </param>
        /// <param name="clientSecret">
        /// The client secret used in API requests.  The secret should be kept secure.
        /// </param>
        /// <param name="apiRoles">
        /// The API roles attached to the App Client.
        /// </param>
        /// <param name="apiPolicy">
        /// What actions a principal can take on the Vectara platform.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AppClient(
            string? id,
            string? name,
            string? description,
            string? clientId,
            string? clientSecret,
            global::System.Collections.Generic.IList<global::G.ApiRole>? apiRoles,
            global::G.ApiPolicy? apiPolicy)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.ApiRoles = apiRoles;
            this.ApiPolicy = apiPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClient" /> class.
        /// </summary>
        public AppClient()
        {
        }
    }
}