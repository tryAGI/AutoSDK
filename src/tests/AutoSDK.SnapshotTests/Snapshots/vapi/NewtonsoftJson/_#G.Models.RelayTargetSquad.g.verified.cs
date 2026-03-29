//HintName: G.Models.RelayTargetSquad.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RelayTargetSquad
    {
        /// <summary>
        /// The type of relay target
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RelayTargetSquadType Type { get; set; }

        /// <summary>
        /// The unique identifier of the squad
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// The name of the squad
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squadName")]
        public string? SquadName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayTargetSquad" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of relay target
        /// </param>
        /// <param name="squadId">
        /// The unique identifier of the squad
        /// </param>
        /// <param name="squadName">
        /// The name of the squad
        /// </param>
        public RelayTargetSquad(
            global::G.RelayTargetSquadType type,
            string? squadId,
            string? squadName)
        {
            this.Type = type;
            this.SquadId = squadId;
            this.SquadName = squadName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayTargetSquad" /> class.
        /// </summary>
        public RelayTargetSquad()
        {
        }
    }
}