//HintName: G.Models.ExecutionConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Execution configuration for the function.
    /// </summary>
    public sealed partial class ExecutionConfiguration
    {
        /// <summary>
        /// Maximum execution time in seconds.<br/>
        /// Default Value: 30<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::Newtonsoft.Json.JsonProperty("max_execution_time_seconds")]
        public int? MaxExecutionTimeSeconds { get; set; }

        /// <summary>
        /// Maximum memory usage in megabytes.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("max_memory_mb")]
        public int? MaxMemoryMb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionConfiguration" /> class.
        /// </summary>
        /// <param name="maxExecutionTimeSeconds">
        /// Maximum execution time in seconds.<br/>
        /// Default Value: 30<br/>
        /// Example: 30
        /// </param>
        /// <param name="maxMemoryMb">
        /// Maximum memory usage in megabytes.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </param>
        public ExecutionConfiguration(
            int? maxExecutionTimeSeconds,
            int? maxMemoryMb)
        {
            this.MaxExecutionTimeSeconds = maxExecutionTimeSeconds;
            this.MaxMemoryMb = maxMemoryMb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionConfiguration" /> class.
        /// </summary>
        public ExecutionConfiguration()
        {
        }
    }
}