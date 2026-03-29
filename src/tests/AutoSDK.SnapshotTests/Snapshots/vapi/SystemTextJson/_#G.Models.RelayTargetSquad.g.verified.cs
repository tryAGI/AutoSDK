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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RelayTargetSquadTypeJsonConverter))]
        public global::G.RelayTargetSquadType Type { get; set; }

        /// <summary>
        /// The unique identifier of the squad
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// The name of the squad
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadName")]
        public string? SquadName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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