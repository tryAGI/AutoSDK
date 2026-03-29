//HintName: G.Models.DescribeBlocksRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DescribeBlocksRequest
    {
        /// <summary>
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Dynamic blocks to be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic_blocks_definitions")]
        public global::System.Collections.Generic.IList<global::G.DynamicBlockDefinition>? DynamicBlocksDefinitions { get; set; }

        /// <summary>
        /// Requested Execution Engine compatibility. If given, result will only contain blocks suitable for requested EE version, otherwise - descriptions for all available blocks will be delivered.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_engine_version")]
        public string? ExecutionEngineVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeBlocksRequest" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="dynamicBlocksDefinitions">
        /// Dynamic blocks to be used.
        /// </param>
        /// <param name="executionEngineVersion">
        /// Requested Execution Engine compatibility. If given, result will only contain blocks suitable for requested EE version, otherwise - descriptions for all available blocks will be delivered.
        /// </param>
        public DescribeBlocksRequest(
            string? apiKey,
            global::System.Collections.Generic.IList<global::G.DynamicBlockDefinition>? dynamicBlocksDefinitions,
            string? executionEngineVersion)
        {
            this.ApiKey = apiKey;
            this.DynamicBlocksDefinitions = dynamicBlocksDefinitions;
            this.ExecutionEngineVersion = executionEngineVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeBlocksRequest" /> class.
        /// </summary>
        public DescribeBlocksRequest()
        {
        }
    }
}