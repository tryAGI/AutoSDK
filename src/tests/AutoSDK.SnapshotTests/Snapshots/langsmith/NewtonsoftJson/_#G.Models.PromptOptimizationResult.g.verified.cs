//HintName: G.Models.PromptOptimizationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOptimizationResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x", Required = global::Newtonsoft.Json.Required.Always)]
        public double X { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y", Required = global::Newtonsoft.Json.Required.Always)]
        public double Y { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationResult" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public PromptOptimizationResult(
            global::System.DateTime timestamp,
            double x,
            double y)
        {
            this.Timestamp = timestamp;
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationResult" /> class.
        /// </summary>
        public PromptOptimizationResult()
        {
        }
    }
}