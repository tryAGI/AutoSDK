//HintName: G.Models.HealthResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HealthResponse
    {
        /// <summary>
        /// Langfuse server version<br/>
        /// Example: 1.25.0
        /// </summary>
        /// <example>1.25.0</example>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Example: OK
        /// </summary>
        /// <example>OK</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthResponse" /> class.
        /// </summary>
        /// <param name="version">
        /// Langfuse server version<br/>
        /// Example: 1.25.0
        /// </param>
        /// <param name="status">
        /// Example: OK
        /// </param>
        public HealthResponse(
            string version,
            string status)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthResponse" /> class.
        /// </summary>
        public HealthResponse()
        {
        }
    }
}