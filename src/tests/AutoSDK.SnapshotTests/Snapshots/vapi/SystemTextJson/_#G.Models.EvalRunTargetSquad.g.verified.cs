//HintName: G.Models.EvalRunTargetSquad.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalRunTargetSquad
    {
        /// <summary>
        /// This is the transient squad that will be run against the eval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squad")]
        public global::G.CreateSquadDTO? Squad { get; set; }

        /// <summary>
        /// This is the overrides that will be applied to the assistants.<br/>
        /// Example: {
        /// </summary>
        /// <example>{</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantOverrides")]
        public global::G.AssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// This is the type of the target.<br/>
        /// Currently it is fixed to `squad`.<br/>
        /// Example: squad
        /// </summary>
        /// <example>squad</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalRunTargetSquadTypeJsonConverter))]
        public global::G.EvalRunTargetSquadType Type { get; set; }

        /// <summary>
        /// This is the id of the squad that will be run against the eval<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunTargetSquad" /> class.
        /// </summary>
        /// <param name="squad">
        /// This is the transient squad that will be run against the eval
        /// </param>
        /// <param name="assistantOverrides">
        /// This is the overrides that will be applied to the assistants.<br/>
        /// Example: {
        /// </param>
        /// <param name="type">
        /// This is the type of the target.<br/>
        /// Currently it is fixed to `squad`.<br/>
        /// Example: squad
        /// </param>
        /// <param name="squadId">
        /// This is the id of the squad that will be run against the eval<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalRunTargetSquad(
            global::G.CreateSquadDTO? squad,
            global::G.AssistantOverrides? assistantOverrides,
            global::G.EvalRunTargetSquadType type,
            string? squadId)
        {
            this.Squad = squad;
            this.AssistantOverrides = assistantOverrides;
            this.Type = type;
            this.SquadId = squadId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunTargetSquad" /> class.
        /// </summary>
        public EvalRunTargetSquad()
        {
        }
    }
}