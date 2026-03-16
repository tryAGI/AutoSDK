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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Error information from the failed execution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TestToolErrorResponseError Error { get; set; } = default!;

        /// <summary>
        /// Time taken before the error occurred in milliseconds.<br/>
        /// Example: 125
        /// </summary>
        /// <example>125</example>
        [global::Newtonsoft.Json.JsonProperty("latency_millis", Required = global::Newtonsoft.Json.Required.Always)]
        public int LatencyMillis { get; set; } = default!;

        /// <summary>
        /// Memory used before the error occurred in megabytes.<br/>
        /// Example: 32
        /// </summary>
        /// <example>32</example>
        [global::Newtonsoft.Json.JsonProperty("memory_used_mb")]
        public long? MemoryUsedMb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public TestToolErrorResponse(
            string type,
            global::G.TestToolErrorResponseError error,
            int latencyMillis,
            long? memoryUsedMb)
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