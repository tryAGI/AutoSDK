//HintName: G.Models.VersionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response class for the version endpoint.
    /// </summary>
    public sealed partial class VersionResponse
    {
        /// <summary>
        /// The version of the Ollama server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionResponse" /> class.
        /// </summary>
        /// <param name="version">
        /// The version of the Ollama server.
        /// </param>
        public VersionResponse(
            string? version)
        {
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionResponse" /> class.
        /// </summary>
        public VersionResponse()
        {
        }
    }
}