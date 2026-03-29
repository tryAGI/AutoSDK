//HintName: G.Models.StateModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for FSM state models.<br/>
    /// Uses Serializer instead of ModelSerializer because BaseState is abstract.<br/>
    /// Works with any concrete state model that inherits from BaseState.
    /// </summary>
    public sealed partial class StateModel
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("context_data")]
        public object ContextData { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_state")]
        public string? PreviousState { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transition_name")]
        public string? TransitionName { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggered_by")]
        public global::G.TriggeredBy? TriggeredBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StateModel" /> class.
        /// </summary>
        /// <param name="previousState">
        /// Included only in responses
        /// </param>
        /// <param name="reason">
        /// Included only in responses
        /// </param>
        /// <param name="transitionName">
        /// Included only in responses
        /// </param>
        /// <param name="triggeredBy">
        /// Included only in responses
        /// </param>
        /// <param name="contextData">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// Included only in responses
        /// </param>
        public StateModel(
            string? previousState,
            string? reason,
            string? transitionName,
            global::G.TriggeredBy? triggeredBy,
            object contextData = default!,
            global::System.DateTime createdAt = default!,
            global::System.Guid id = default!,
            string state = default!)
        {
            this.ContextData = contextData;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.PreviousState = previousState;
            this.Reason = reason;
            this.State = state;
            this.TransitionName = transitionName;
            this.TriggeredBy = triggeredBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StateModel" /> class.
        /// </summary>
        public StateModel()
        {
        }
    }
}