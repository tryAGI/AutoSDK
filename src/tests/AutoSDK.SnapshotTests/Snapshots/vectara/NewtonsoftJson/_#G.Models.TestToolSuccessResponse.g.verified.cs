//HintName: G.Models.TestToolSuccessResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Successful execution response from testing a Lambda tool.
    /// </summary>
    public sealed partial class TestToolSuccessResponse
    {
        /// <summary>
        /// Response type indicator. Always "success" for successful executions.<br/>
        /// Default Value: success<br/>
        /// Example: success
        /// </summary>
        /// <default>"success"</default>
        /// <example>success</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The output returned by the function.<br/>
        /// Example: {"result":1764,"message":"Computed successfully"}
        /// </summary>
        /// <example>{"result":1764,"message":"Computed successfully"}</example>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public object Output { get; set; } = default!;

        /// <summary>
        /// Time taken to execute the function in milliseconds.<br/>
        /// Example: 125
        /// </summary>
        /// <example>125</example>
        [global::Newtonsoft.Json.JsonProperty("latency_millis", Required = global::Newtonsoft.Json.Required.Always)]
        public int LatencyMillis { get; set; } = default!;

        /// <summary>
        /// Memory used during execution in megabytes.<br/>
        /// Example: 32
        /// </summary>
        /// <example>32</example>
        [global::Newtonsoft.Json.JsonProperty("memory_used_mb")]
        public int? MemoryUsedMb { get; set; }

        /// <summary>
        /// Results of input/output schema validation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_results")]
        public global::G.TestToolSuccessResponseValidationResults? ValidationResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolSuccessResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Response type indicator. Always "success" for successful executions.<br/>
        /// Default Value: success<br/>
        /// Example: success
        /// </param>
        /// <param name="output">
        /// The output returned by the function.<br/>
        /// Example: {"result":1764,"message":"Computed successfully"}
        /// </param>
        /// <param name="latencyMillis">
        /// Time taken to execute the function in milliseconds.<br/>
        /// Example: 125
        /// </param>
        /// <param name="memoryUsedMb">
        /// Memory used during execution in megabytes.<br/>
        /// Example: 32
        /// </param>
        /// <param name="validationResults">
        /// Results of input/output schema validation.
        /// </param>
        public TestToolSuccessResponse(
            string type,
            object output,
            int latencyMillis,
            int? memoryUsedMb,
            global::G.TestToolSuccessResponseValidationResults? validationResults)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.LatencyMillis = latencyMillis;
            this.MemoryUsedMb = memoryUsedMb;
            this.ValidationResults = validationResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolSuccessResponse" /> class.
        /// </summary>
        public TestToolSuccessResponse()
        {
        }
    }
}