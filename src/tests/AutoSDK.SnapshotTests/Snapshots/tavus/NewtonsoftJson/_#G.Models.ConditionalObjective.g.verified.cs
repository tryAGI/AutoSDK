//HintName: G.Models.ConditionalObjective.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConditionalObjective
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition")]
        public string? Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objective_id")]
        public string? ObjectiveId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalObjective" /> class.
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="objectiveId"></param>
        public ConditionalObjective(
            string? condition,
            string? objectiveId)
        {
            this.Condition = condition;
            this.ObjectiveId = objectiveId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalObjective" /> class.
        /// </summary>
        public ConditionalObjective()
        {
        }
    }
}