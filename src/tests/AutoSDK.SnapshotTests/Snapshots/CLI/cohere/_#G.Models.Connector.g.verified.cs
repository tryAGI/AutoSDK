﻿//HintName: G.Models.Connector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A connector allows you to integrate data sources with the '/chat' endpoint to create grounded generations with citations to the data source.<br/>
    /// documents to help answer users.
    /// </summary>
    public sealed partial class Connector
    {
        /// <summary>
        /// Whether the connector is active or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// The OAuth status for the user making the request. One of ["valid", "expired", ""]. Empty string (field is omitted) means the user has not authorized the connector yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConnectorAuthStatusJsonConverter))]
        public global::G.ConnectorAuthStatus? AuthStatus { get; set; }

        /// <summary>
        /// The type of authentication/authorization used by the connector. Possible values: [oauth, service_auth]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public string? AuthType { get; set; }

        /// <summary>
        /// Whether a chat request should continue or not if the request to this connector fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continue_on_failure")]
        public bool? ContinueOnFailure { get; set; }

        /// <summary>
        /// The UTC time at which the connector was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A description of the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A list of fields to exclude from the prompt (fields remain in the document).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludes")]
        public global::System.Collections.Generic.IList<string>? Excludes { get; set; }

        /// <summary>
        /// The unique identifier of the connector (used in both `/connectors` &amp; `/chat` endpoints).<br/>
        /// This is automatically created from the name of the connector upon registration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A human-readable name for the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth")]
        public global::G.ConnectorOAuth? Oauth { get; set; }

        /// <summary>
        /// The organization to which this connector belongs. This is automatically set to<br/>
        /// the organization of the user who created the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// The UTC time at which the connector was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The URL of the connector that will be used to search for documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Connector" /> class.
        /// </summary>
        /// <param name="active">
        /// Whether the connector is active or not.
        /// </param>
        /// <param name="authStatus">
        /// The OAuth status for the user making the request. One of ["valid", "expired", ""]. Empty string (field is omitted) means the user has not authorized the connector yet.
        /// </param>
        /// <param name="authType">
        /// The type of authentication/authorization used by the connector. Possible values: [oauth, service_auth]
        /// </param>
        /// <param name="continueOnFailure">
        /// Whether a chat request should continue or not if the request to this connector fails.
        /// </param>
        /// <param name="createdAt">
        /// The UTC time at which the connector was created.
        /// </param>
        /// <param name="description">
        /// A description of the connector.
        /// </param>
        /// <param name="excludes">
        /// A list of fields to exclude from the prompt (fields remain in the document).
        /// </param>
        /// <param name="id">
        /// The unique identifier of the connector (used in both `/connectors` &amp; `/chat` endpoints).<br/>
        /// This is automatically created from the name of the connector upon registration.
        /// </param>
        /// <param name="name">
        /// A human-readable name for the connector.
        /// </param>
        /// <param name="oauth"></param>
        /// <param name="organizationId">
        /// The organization to which this connector belongs. This is automatically set to<br/>
        /// the organization of the user who created the connector.
        /// </param>
        /// <param name="updatedAt">
        /// The UTC time at which the connector was last updated.
        /// </param>
        /// <param name="url">
        /// The URL of the connector that will be used to search for documents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Connector(
            global::System.DateTime createdAt,
            string id,
            string name,
            global::System.DateTime updatedAt,
            bool? active,
            global::G.ConnectorAuthStatus? authStatus,
            string? authType,
            bool? continueOnFailure,
            string? description,
            global::System.Collections.Generic.IList<string>? excludes,
            global::G.ConnectorOAuth? oauth,
            string? organizationId,
            string? url)
        {
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UpdatedAt = updatedAt;
            this.Active = active;
            this.AuthStatus = authStatus;
            this.AuthType = authType;
            this.ContinueOnFailure = continueOnFailure;
            this.Description = description;
            this.Excludes = excludes;
            this.Oauth = oauth;
            this.OrganizationId = organizationId;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Connector" /> class.
        /// </summary>
        public Connector()
        {
        }
    }
}