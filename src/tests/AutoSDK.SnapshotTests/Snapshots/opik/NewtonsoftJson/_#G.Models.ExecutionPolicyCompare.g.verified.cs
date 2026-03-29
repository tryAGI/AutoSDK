//HintName: G.Models.ExecutionPolicyCompare.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutionPolicyCompare
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runs_per_item")]
        public int? RunsPerItem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pass_threshold")]
        public int? PassThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionPolicyCompare" /> class.
        /// </summary>
        /// <param name="runsPerItem"></param>
        /// <param name="passThreshold"></param>
        public ExecutionPolicyCompare(
            int? runsPerItem,
            int? passThreshold)
        {
            this.RunsPerItem = runsPerItem;
            this.PassThreshold = passThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionPolicyCompare" /> class.
        /// </summary>
        public ExecutionPolicyCompare()
        {
        }
    }
}