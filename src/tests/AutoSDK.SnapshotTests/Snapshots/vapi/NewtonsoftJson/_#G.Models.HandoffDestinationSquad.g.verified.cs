//HintName: G.Models.HandoffDestinationSquad.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HandoffDestinationSquad
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.HandoffDestinationSquadType Type { get; set; }

        /// <summary>
        /// This is the plan for manipulating the message context before handing off the call to the squad.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contextEngineeringPlan")]
        public global::G.OneOf<global::G.ContextEngineeringPlanLastNMessages, global::G.ContextEngineeringPlanNone, global::G.ContextEngineeringPlanAll, global::G.ContextEngineeringPlanUserAndAssistantMessages>? ContextEngineeringPlan { get; set; }

        /// <summary>
        /// This is the squad id to transfer the call to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is a transient squad to transfer the call to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squad")]
        public global::G.CreateSquadDTO? Squad { get; set; }

        /// <summary>
        /// This is the name of the entry assistant to start with when handing off to the squad.<br/>
        /// If not provided, the first member of the squad will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entryAssistantName")]
        public string? EntryAssistantName { get; set; }

        /// <summary>
        /// This is the variable extraction plan for the handoff tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variableExtractionPlan")]
        public global::G.VariableExtractionPlan? VariableExtractionPlan { get; set; }

        /// <summary>
        /// These are the overrides to apply to the squad configuration.<br/>
        /// Maps to squad-level membersOverrides.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squadOverrides")]
        public global::G.AssistantOverrides? SquadOverrides { get; set; }

        /// <summary>
        /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HandoffDestinationSquad" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="contextEngineeringPlan">
        /// This is the plan for manipulating the message context before handing off the call to the squad.
        /// </param>
        /// <param name="squadId">
        /// This is the squad id to transfer the call to.
        /// </param>
        /// <param name="squad">
        /// This is a transient squad to transfer the call to.
        /// </param>
        /// <param name="entryAssistantName">
        /// This is the name of the entry assistant to start with when handing off to the squad.<br/>
        /// If not provided, the first member of the squad will be used.
        /// </param>
        /// <param name="variableExtractionPlan">
        /// This is the variable extraction plan for the handoff tool.
        /// </param>
        /// <param name="squadOverrides">
        /// These are the overrides to apply to the squad configuration.<br/>
        /// Maps to squad-level membersOverrides.
        /// </param>
        /// <param name="description">
        /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
        /// </param>
        public HandoffDestinationSquad(
            global::G.HandoffDestinationSquadType type,
            global::G.OneOf<global::G.ContextEngineeringPlanLastNMessages, global::G.ContextEngineeringPlanNone, global::G.ContextEngineeringPlanAll, global::G.ContextEngineeringPlanUserAndAssistantMessages>? contextEngineeringPlan,
            string? squadId,
            global::G.CreateSquadDTO? squad,
            string? entryAssistantName,
            global::G.VariableExtractionPlan? variableExtractionPlan,
            global::G.AssistantOverrides? squadOverrides,
            string? description)
        {
            this.Type = type;
            this.ContextEngineeringPlan = contextEngineeringPlan;
            this.SquadId = squadId;
            this.Squad = squad;
            this.EntryAssistantName = entryAssistantName;
            this.VariableExtractionPlan = variableExtractionPlan;
            this.SquadOverrides = squadOverrides;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HandoffDestinationSquad" /> class.
        /// </summary>
        public HandoffDestinationSquad()
        {
        }
    }
}