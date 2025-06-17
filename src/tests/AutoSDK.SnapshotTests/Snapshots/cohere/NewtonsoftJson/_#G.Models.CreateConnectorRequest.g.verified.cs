﻿//HintName: G.Models.CreateConnectorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConnectorRequest
    {
        /// <summary>
        /// Whether the connector is active or not.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Whether a chat request should continue or not if the request to this connector fails.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("continue_on_failure")]
        public bool? ContinueOnFailure { get; set; }

        /// <summary>
        /// A description of the connector.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A list of fields to exclude from the prompt (fields remain in the document).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excludes")]
        public global::System.Collections.Generic.IList<string>? Excludes { get; set; }

        /// <summary>
        /// A human-readable name for the connector.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("oauth")]
        public global::G.CreateConnectorOAuth? Oauth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service_auth")]
        public global::G.CreateConnectorServiceAuth? ServiceAuth { get; set; }

        /// <summary>
        /// The URL of the connector that will be used to search for documents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequest" /> class.
        /// </summary>
        /// <param name="active">
        /// Whether the connector is active or not.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="continueOnFailure">
        /// Whether a chat request should continue or not if the request to this connector fails.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="description">
        /// A description of the connector.
        /// </param>
        /// <param name="excludes">
        /// A list of fields to exclude from the prompt (fields remain in the document).
        /// </param>
        /// <param name="name">
        /// A human-readable name for the connector.
        /// </param>
        /// <param name="oauth"></param>
        /// <param name="serviceAuth"></param>
        /// <param name="url">
        /// The URL of the connector that will be used to search for documents.
        /// </param>
        public CreateConnectorRequest(
            string name,
            string url,
            bool? active,
            bool? continueOnFailure,
            string? description,
            global::System.Collections.Generic.IList<string>? excludes,
            global::G.CreateConnectorOAuth? oauth,
            global::G.CreateConnectorServiceAuth? serviceAuth)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Active = active;
            this.ContinueOnFailure = continueOnFailure;
            this.Description = description;
            this.Excludes = excludes;
            this.Oauth = oauth;
            this.ServiceAuth = serviceAuth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConnectorRequest" /> class.
        /// </summary>
        public CreateConnectorRequest()
        {
        }
    }
}