//HintName: G.Models.OllamaConnectionTestResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from Ollama connection test.
    /// </summary>
    public sealed partial class OllamaConnectionTestResponse
    {
        /// <summary>
        /// Whether the connection was successful
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connected")]
        public bool? Connected { get; set; }

        /// <summary>
        /// Server version (returned even if connection failed or version is incompatible)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Error message if connection failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OllamaConnectionTestResponse" /> class.
        /// </summary>
        /// <param name="connected">
        /// Whether the connection was successful
        /// </param>
        /// <param name="version">
        /// Server version (returned even if connection failed or version is incompatible)
        /// </param>
        /// <param name="errorMessage">
        /// Error message if connection failed
        /// </param>
        public OllamaConnectionTestResponse(
            bool? connected,
            string? version,
            string? errorMessage)
        {
            this.Connected = connected;
            this.Version = version;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OllamaConnectionTestResponse" /> class.
        /// </summary>
        public OllamaConnectionTestResponse()
        {
        }
    }
}