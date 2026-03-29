//HintName: G.Models.Server.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Server
    {
        /// <summary>
        /// This is the timeout in seconds for the request. Defaults to 20 seconds.<br/>
        /// @default 20<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// The credential ID for server authentication<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentialId")]
        public string? CredentialId { get; set; }

        /// <summary>
        /// If enabled, requests will originate from a static set of IPs owned and managed by Vapi.<br/>
        /// @default false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("staticIpAddressesEnabled")]
        public bool? StaticIpAddressesEnabled { get; set; }

        /// <summary>
        /// This is the paths to encrypt in the request body if credentialId and encryptionPlan are defined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryptedPaths")]
        public global::System.Collections.Generic.IList<string>? EncryptedPaths { get; set; }

        /// <summary>
        /// This is where the request will be sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// These are the headers to include in the request.<br/>
        /// Each key-value pair represents a header name and its value.<br/>
        /// Note: Specifying an Authorization header here will override the authorization provided by the `credentialId` (if provided). This is an anti-pattern and should be avoided outside of edge case scenarios.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// This is the backoff plan if the request fails. Defaults to undefined (the request will not be retried).<br/>
        /// @default undefined (the request will not be retried)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backoffPlan")]
        public global::G.BackoffPlan? BackoffPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Server" /> class.
        /// </summary>
        /// <param name="timeoutSeconds">
        /// This is the timeout in seconds for the request. Defaults to 20 seconds.<br/>
        /// @default 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="credentialId">
        /// The credential ID for server authentication<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="staticIpAddressesEnabled">
        /// If enabled, requests will originate from a static set of IPs owned and managed by Vapi.<br/>
        /// @default false<br/>
        /// Example: false
        /// </param>
        /// <param name="encryptedPaths">
        /// This is the paths to encrypt in the request body if credentialId and encryptionPlan are defined.
        /// </param>
        /// <param name="url">
        /// This is where the request will be sent.
        /// </param>
        /// <param name="headers">
        /// These are the headers to include in the request.<br/>
        /// Each key-value pair represents a header name and its value.<br/>
        /// Note: Specifying an Authorization header here will override the authorization provided by the `credentialId` (if provided). This is an anti-pattern and should be avoided outside of edge case scenarios.
        /// </param>
        /// <param name="backoffPlan">
        /// This is the backoff plan if the request fails. Defaults to undefined (the request will not be retried).<br/>
        /// @default undefined (the request will not be retried)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Server(
            double? timeoutSeconds,
            string? credentialId,
            bool? staticIpAddressesEnabled,
            global::System.Collections.Generic.IList<string>? encryptedPaths,
            string? url,
            object? headers,
            global::G.BackoffPlan? backoffPlan)
        {
            this.TimeoutSeconds = timeoutSeconds;
            this.CredentialId = credentialId;
            this.StaticIpAddressesEnabled = staticIpAddressesEnabled;
            this.EncryptedPaths = encryptedPaths;
            this.Url = url;
            this.Headers = headers;
            this.BackoffPlan = backoffPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Server" /> class.
        /// </summary>
        public Server()
        {
        }
    }
}