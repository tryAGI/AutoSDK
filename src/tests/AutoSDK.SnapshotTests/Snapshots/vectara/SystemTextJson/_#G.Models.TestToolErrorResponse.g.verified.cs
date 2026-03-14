//HintName: G.Models.TestToolErrorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error response from testing a Lambda tool.
    /// </summary>
    public sealed partial class TestToolErrorResponse
    {
        /// <summary>
        /// Response type indicator. Always "error" for failed executions.<br/>
        /// Default Value: error<br/>
        /// Example: error
        /// </summary>
        /// <default>"error"</default>
        /// <example>error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "error";

        /// <summary>
        /// Error information from the failed execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TestToolErrorResponseError Error { get; set; }

        /// <summary>
        /// Time taken before the error occurred in milliseconds.<br/>
        /// Example: 125
        /// </summary>
        /// <example>125</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_millis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LatencyMillis { get; set; }

        /// <summary>
        /// Memory used before the error occurred in megabytes.<br/>
        /// Example: 32
        /// </summary>
        /// <example>32</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_used_mb")]
        public int? MemoryUsedMb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolErrorResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Response type indicator. Always "error" for failed executions.<br/>
        /// Default Value: error<br/>
        /// Example: error
        /// </param>
        /// <param name="error">
        /// Error information from the failed execution.
        /// </param>
        /// <param name="latencyMillis">
        /// Time taken before the error occurred in milliseconds.<br/>
        /// Example: 125
        /// </param>
        /// <param name="memoryUsedMb">
        /// Memory used before the error occurred in megabytes.<br/>
        /// Example: 32
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestToolErrorResponse(
            string type,
            global::G.TestToolErrorResponseError error,
            int latencyMillis,
            int? memoryUsedMb)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.LatencyMillis = latencyMillis;
            this.MemoryUsedMb = memoryUsedMb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolErrorResponse" /> class.
        /// </summary>
        public TestToolErrorResponse()
        {
        }
    }
}