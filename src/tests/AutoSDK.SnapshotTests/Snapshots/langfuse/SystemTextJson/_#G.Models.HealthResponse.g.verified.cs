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
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Example: OK
        /// </summary>
        /// <example>OK</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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