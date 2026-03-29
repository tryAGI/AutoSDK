//HintName: G.Models.ExecutionPolicyPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default execution policy for items in this version<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class ExecutionPolicyPublic
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
        /// Initializes a new instance of the <see cref="ExecutionPolicyPublic" /> class.
        /// </summary>
        /// <param name="runsPerItem"></param>
        /// <param name="passThreshold"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionPolicyPublic(
            int? runsPerItem,
            int? passThreshold)
        {
            this.RunsPerItem = runsPerItem;
            this.PassThreshold = passThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionPolicyPublic" /> class.
        /// </summary>
        public ExecutionPolicyPublic()
        {
        }
    }
}