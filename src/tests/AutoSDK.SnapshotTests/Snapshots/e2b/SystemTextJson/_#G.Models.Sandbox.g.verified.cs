//HintName: G.Models.Sandbox.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sandbox
    {
        /// <summary>
        /// Identifier of the template from which is the sandbox created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// Identifier of the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxID { get; set; }

        /// <summary>
        /// Alias of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Identifier of the client
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientID { get; set; }

        /// <summary>
        /// Version of the envd running in the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envdVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvdVersion { get; set; }

        /// <summary>
        /// Access token used for envd communication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envdAccessToken")]
        public string? EnvdAccessToken { get; set; }

        /// <summary>
        /// Token required for accessing sandbox via proxy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trafficAccessToken")]
        public string? TrafficAccessToken { get; set; }

        /// <summary>
        /// Base domain where the sandbox traffic is accessible
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sandbox" /> class.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the template from which is the sandbox created
        /// </param>
        /// <param name="sandboxID">
        /// Identifier of the sandbox
        /// </param>
        /// <param name="clientID">
        /// Identifier of the client
        /// </param>
        /// <param name="envdVersion">
        /// Version of the envd running in the sandbox
        /// </param>
        /// <param name="alias">
        /// Alias of the template
        /// </param>
        /// <param name="envdAccessToken">
        /// Access token used for envd communication
        /// </param>
        /// <param name="trafficAccessToken">
        /// Token required for accessing sandbox via proxy.
        /// </param>
        /// <param name="domain">
        /// Base domain where the sandbox traffic is accessible
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sandbox(
            string templateID,
            string sandboxID,
            string clientID,
            string envdVersion,
            string? alias,
            string? envdAccessToken,
            string? trafficAccessToken,
            string? domain)
        {
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.SandboxID = sandboxID ?? throw new global::System.ArgumentNullException(nameof(sandboxID));
            this.Alias = alias;
            this.ClientID = clientID ?? throw new global::System.ArgumentNullException(nameof(clientID));
            this.EnvdVersion = envdVersion ?? throw new global::System.ArgumentNullException(nameof(envdVersion));
            this.EnvdAccessToken = envdAccessToken;
            this.TrafficAccessToken = trafficAccessToken;
            this.Domain = domain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sandbox" /> class.
        /// </summary>
        public Sandbox()
        {
        }
    }
}