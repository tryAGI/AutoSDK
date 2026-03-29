//HintName: G.Models.RoundRobinManager.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RoundRobinManager
    {
        /// <summary>
        /// Default Value: round_robin
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_type")]
        public string? ManagerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_turns")]
        public int? MaxTurns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoundRobinManager" /> class.
        /// </summary>
        /// <param name="managerType">
        /// Default Value: round_robin
        /// </param>
        /// <param name="maxTurns"></param>
        public RoundRobinManager(
            string? managerType,
            int? maxTurns)
        {
            this.ManagerType = managerType;
            this.MaxTurns = maxTurns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoundRobinManager" /> class.
        /// </summary>
        public RoundRobinManager()
        {
        }
    }
}