//HintName: G.Models.ExecutionPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs_per_item")]
        public int? RunsPerItem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_threshold")]
        public int? PassThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionPolicy" /> class.
        /// </summary>
        /// <param name="runsPerItem"></param>
        /// <param name="passThreshold"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionPolicy(
            int? runsPerItem,
            int? passThreshold)
        {
            this.RunsPerItem = runsPerItem;
            this.PassThreshold = passThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionPolicy" /> class.
        /// </summary>
        public ExecutionPolicy()
        {
        }
    }
}