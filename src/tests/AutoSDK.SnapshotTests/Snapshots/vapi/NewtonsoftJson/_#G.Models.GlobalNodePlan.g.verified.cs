//HintName: G.Models.GlobalNodePlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GlobalNodePlan
    {
        /// <summary>
        /// This is the flag to determine if this node is a global node<br/>
        /// @default false<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// This is the condition that will be checked to determine if the global node should be executed.<br/>
        /// @default ''
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enterCondition")]
        public string? EnterCondition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNodePlan" /> class.
        /// </summary>
        /// <param name="enabled">
        /// This is the flag to determine if this node is a global node<br/>
        /// @default false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enterCondition">
        /// This is the condition that will be checked to determine if the global node should be executed.<br/>
        /// @default ''
        /// </param>
        public GlobalNodePlan(
            bool? enabled,
            string? enterCondition)
        {
            this.Enabled = enabled;
            this.EnterCondition = enterCondition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalNodePlan" /> class.
        /// </summary>
        public GlobalNodePlan()
        {
        }
    }
}