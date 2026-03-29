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
        [global::Newtonsoft.Json.JsonProperty("templateID", Required = global::Newtonsoft.Json.Required.Always)]
        public string TemplateID { get; set; } = default!;

        /// <summary>
        /// Identifier of the sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sandboxID", Required = global::Newtonsoft.Json.Required.Always)]
        public string SandboxID { get; set; } = default!;

        /// <summary>
        /// Alias of the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Identifier of the client
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clientID", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClientID { get; set; } = default!;

        /// <summary>
        /// Version of the envd running in the sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("envdVersion", Required = global::Newtonsoft.Json.Required.Always)]
        public string EnvdVersion { get; set; } = default!;

        /// <summary>
        /// Access token used for envd communication
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("envdAccessToken")]
        public string? EnvdAccessToken { get; set; }

        /// <summary>
        /// Token required for accessing sandbox via proxy.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trafficAccessToken")]
        public string? TrafficAccessToken { get; set; }

        /// <summary>
        /// Base domain where the sandbox traffic is accessible
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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