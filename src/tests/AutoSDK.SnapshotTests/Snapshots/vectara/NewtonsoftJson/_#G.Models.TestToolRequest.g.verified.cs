//HintName: G.Models.TestToolRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to test a Lambda tool with sample input.
    /// </summary>
    public sealed partial class TestToolRequest
    {
        /// <summary>
        /// The input parameters to pass to the function. Must match the tool's input schema.<br/>
        /// Example: {"number":42,"text":"Hello, world!"}
        /// </summary>
        /// <example>{"number":42,"text":"Hello, world!"}</example>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public object Input { get; set; } = default!;

        /// <summary>
        /// Maximum execution time in seconds. If not specified, uses the tool's configured timeout.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("timeout_seconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// The input parameters to pass to the function. Must match the tool's input schema.<br/>
        /// Example: {"number":42,"text":"Hello, world!"}
        /// </param>
        /// <param name="timeoutSeconds">
        /// Maximum execution time in seconds. If not specified, uses the tool's configured timeout.<br/>
        /// Example: 10
        /// </param>
        public TestToolRequest(
            object input,
            int? timeoutSeconds)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolRequest" /> class.
        /// </summary>
        public TestToolRequest()
        {
        }
    }
}