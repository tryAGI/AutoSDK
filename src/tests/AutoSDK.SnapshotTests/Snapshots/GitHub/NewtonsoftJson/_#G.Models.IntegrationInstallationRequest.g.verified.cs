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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: MDExOkludGVncmF0aW9uMQ==
        /// </summary>
        /// <example>MDExOkludGVncmF0aW9uMQ==</example>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.SimpleUser, global::G.Enterprise> Account { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requester", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Requester { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="createdAt"></param>
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