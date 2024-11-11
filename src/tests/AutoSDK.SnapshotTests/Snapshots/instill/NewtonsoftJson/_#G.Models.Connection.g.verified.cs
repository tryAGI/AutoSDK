//HintName: G.Models.Connection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Connection contains the parameters to communicate with a 3rd party app. A<br/>
    /// component may reference a connection in their setup. One connection may be<br/>
    /// used by several components and pipelines.
    /// </summary>
    public sealed partial class Connection
    {
        /// <summary>
        /// UUID-formatted unique identifier.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// ID of the namespace owning the connection.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("namespaceId")]
        public string? NamespaceId { get; set; }

        /// <summary>
        /// Integration ID. It determines for which type of components can reference<br/>
        /// this connection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integrationId", Required = global::Newtonsoft.Json.Required.Always)]
        public string IntegrationId { get; set; } = default!;

        /// <summary>
        /// Integration title. This helps the console display the results grouped by<br/>
        /// integration ID without needing an extra call to fetch title by integration<br/>
        /// ID.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integrationTitle")]
        public string? IntegrationTitle { get; set; }

        /// <summary>
        /// Connection method. It references the setup schema provided by the<br/>
        /// integration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Method Method { get; set; } = default!;

        /// <summary>
        /// Connection details. This field is required on creation, optional on view.<br/>
        /// When viewing the connection details, the setup values will be redacted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("setup", Required = global::Newtonsoft.Json.Required.Always)]
        public object Setup { get; set; } = default!;

        /// <summary>
        /// A list of scopes that identify the resources that the connection will be<br/>
        /// able to access on the user's behalf. This is typically passed on creation<br/>
        /// when the setup has been generated through an OAuth flow with a limited set<br/>
        /// of scopes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// When the connection method is METHOD_OAUTH, this field will hold the<br/>
        /// identity (e.g., email, username) with which the access token has been<br/>
        /// generated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identity")]
        public string? Identity { get; set; }

        /// <summary>
        /// When the connection method is METHOD_OAUTH, the access token might come<br/>
        /// with some extra information that might vary across vendors. This<br/>
        /// information is passed as connection metadata.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("oAuthAccessDetails")]
        public object? OAuthAccessDetails { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("view")]
        public global::G.PipelineV1betaView? View { get; set; }

        /// <summary>
        /// Creation timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Last update timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Connection" /> class.
        /// </summary>
        /// <param name="uid">
        /// UUID-formatted unique identifier.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// ID.
        /// </param>
        /// <param name="namespaceId">
        /// ID of the namespace owning the connection.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="integrationId">
        /// Integration ID. It determines for which type of components can reference<br/>
        /// this connection.
        /// </param>
        /// <param name="integrationTitle">
        /// Integration title. This helps the console display the results grouped by<br/>
        /// integration ID without needing an extra call to fetch title by integration<br/>
        /// ID.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="method">
        /// Connection method. It references the setup schema provided by the<br/>
        /// integration.
        /// </param>
        /// <param name="setup">
        /// Connection details. This field is required on creation, optional on view.<br/>
        /// When viewing the connection details, the setup values will be redacted.
        /// </param>
        /// <param name="scopes">
        /// A list of scopes that identify the resources that the connection will be<br/>
        /// able to access on the user's behalf. This is typically passed on creation<br/>
        /// when the setup has been generated through an OAuth flow with a limited set<br/>
        /// of scopes.
        /// </param>
        /// <param name="identity">
        /// When the connection method is METHOD_OAUTH, this field will hold the<br/>
        /// identity (e.g., email, username) with which the access token has been<br/>
        /// generated.
        /// </param>
        /// <param name="oAuthAccessDetails">
        /// When the connection method is METHOD_OAUTH, the access token might come<br/>
        /// with some extra information that might vary across vendors. This<br/>
        /// information is passed as connection metadata.
        /// </param>
        /// <param name="view">
        /// Included only in responses
        /// </param>
        /// <param name="createTime">
        /// Creation timestamp.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Last update timestamp.<br/>
        /// Included only in responses
        /// </param>
        public Connection(
            string id,
            string integrationId,
            global::G.Method method,
            object setup,
            string? uid,
            string? namespaceId,
            string? integrationTitle,
            global::System.Collections.Generic.IList<string>? scopes,
            string? identity,
            object? oAuthAccessDetails,
            global::G.PipelineV1betaView? view,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.Method = method;
            this.Setup = setup ?? throw new global::System.ArgumentNullException(nameof(setup));
            this.Uid = uid;
            this.NamespaceId = namespaceId;
            this.IntegrationTitle = integrationTitle;
            this.Scopes = scopes;
            this.Identity = identity;
            this.OAuthAccessDetails = oAuthAccessDetails;
            this.View = view;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Connection" /> class.
        /// </summary>
        public Connection()
        {
        }
    }
}