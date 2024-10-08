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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The human-readable name of the App Client.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the App Client.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The client ID used with the OAuth flow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// The client secret used in API requests.  The secret should be kept secure.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// The API roles attached to the App Client.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_roles")]
        public global::System.Collections.Generic.IList<global::G.ApiRole>? ApiRoles { get; set; }

        /// <summary>
        /// What actions a principal can take on the Vectara platform.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_policy")]
        public global::G.ApiPolicy? ApiPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}