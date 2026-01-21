//HintName: G.Models.IntegrationInstallationRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Request to install an integration on a target
    /// </summary>
    public sealed partial class IntegrationInstallationRequest
    {
        /// <summary>
        /// Unique identifier of the request installation.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDExOkludGVncmF0aW9uMQ==
        /// </summary>
        /// <example>MDExOkludGVncmF0aW9uMQ==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.SimpleUser, global::G.Enterprise>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.SimpleUser, global::G.Enterprise> Account { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requester")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser Requester { get; set; }

        /// <summary>
        /// Example: 2022-07-08T16:18:44-04:00
        /// </summary>
        /// <example>2022-07-08T16:18:44-04:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationInstallationRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the request installation.<br/>
        /// Example: 42
        /// </param>
        /// <param name="nodeId">
        /// Example: MDExOkludGVncmF0aW9uMQ==
        /// </param>
        /// <param name="account"></param>
        /// <param name="requester">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt">
        /// Example: 2022-07-08T16:18:44-04:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationInstallationRequest(
            int id,
            global::G.AnyOf<global::G.SimpleUser, global::G.Enterprise> account,
            global::G.SimpleUser requester,
            global::System.DateTime createdAt,
            string? nodeId)
        {
            this.Id = id;
            this.Account = account;
            this.Requester = requester ?? throw new global::System.ArgumentNullException(nameof(requester));
            this.CreatedAt = createdAt;
            this.NodeId = nodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationInstallationRequest" /> class.
        /// </summary>
        public IntegrationInstallationRequest()
        {
        }
    }
}