//HintName: G.Models.SimpleInstallation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
    /// for and sent to a GitHub App. For more information,<br/>
    /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
    /// </summary>
    public sealed partial class SimpleInstallation
    {
        /// <summary>
        /// The ID of the installation.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The global node ID of the installation.<br/>
        /// Example: MDQ6VXNlcjU4MzIzMQ==
        /// </summary>
        /// <example>MDQ6VXNlcjU4MzIzMQ==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleInstallation" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the installation.<br/>
        /// Example: 1
        /// </param>
        /// <param name="nodeId">
        /// The global node ID of the installation.<br/>
        /// Example: MDQ6VXNlcjU4MzIzMQ==
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimpleInstallation(
            int id,
            string nodeId)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleInstallation" /> class.
        /// </summary>
        public SimpleInstallation()
        {
        }
    }
}