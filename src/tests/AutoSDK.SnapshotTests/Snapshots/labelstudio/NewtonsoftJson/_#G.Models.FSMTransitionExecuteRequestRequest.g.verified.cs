//HintName: G.Models.FSMTransitionExecuteRequestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body serializer for executing a manual FSM transition.
    /// </summary>
    public sealed partial class FSMTransitionExecuteRequestRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transition_data")]
        public object? TransitionData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transition_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string TransitionName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FSMTransitionExecuteRequestRequest" /> class.
        /// </summary>
        /// <param name="transitionName"></param>
        /// <param name="transitionData"></param>
        public FSMTransitionExecuteRequestRequest(
            string transitionName,
            object? transitionData)
        {
            this.TransitionData = transitionData;
            this.TransitionName = transitionName ?? throw new global::System.ArgumentNullException(nameof(transitionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FSMTransitionExecuteRequestRequest" /> class.
        /// </summary>
        public FSMTransitionExecuteRequestRequest()
        {
        }
    }
}