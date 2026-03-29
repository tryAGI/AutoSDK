//HintName: G.Models.FSMTransitionExecuteResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response serializer for manual FSM transition execution.
    /// </summary>
    public sealed partial class FSMTransitionExecuteResponse
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_state")]
        public string? NewState { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state_record")]
        public global::G.StateModel? StateRecord { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FSMTransitionExecuteResponse" /> class.
        /// </summary>
        /// <param name="newState">
        /// Included only in responses
        /// </param>
        /// <param name="stateRecord">
        /// Included only in responses
        /// </param>
        /// <param name="success">
        /// Included only in responses
        /// </param>
        public FSMTransitionExecuteResponse(
            string? newState,
            global::G.StateModel? stateRecord,
            bool success = default!)
        {
            this.NewState = newState;
            this.StateRecord = stateRecord;
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FSMTransitionExecuteResponse" /> class.
        /// </summary>
        public FSMTransitionExecuteResponse()
        {
        }
    }
}