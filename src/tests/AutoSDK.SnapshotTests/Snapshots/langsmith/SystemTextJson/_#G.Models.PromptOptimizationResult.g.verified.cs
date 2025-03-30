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
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double X { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptimizationResult" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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