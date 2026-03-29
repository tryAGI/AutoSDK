//HintName: G.Models.RetellLlmRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetellLlmRequestVariant2
    {
        /// <summary>
        /// General prompt appended to system prompt no matter what state the agent is in.<br/>
        /// - System prompt (with state) = general prompt + state prompt.<br/>
        /// - System prompt (no state) = general prompt.<br/>
        /// Example: You are ...
        /// </summary>
        /// <example>You are ...</example>
        [global::Newtonsoft.Json.JsonProperty("general_prompt")]
        public string? GeneralPrompt { get; set; }

        /// <summary>
        /// A list of tools the model may call (to get external knowledge, call API, etc). You can select from some common predefined tools like end call, transfer call, etc; or you can create your own custom tool for the LLM to use.<br/>
        /// - Tools of LLM (with state) = general tools + state tools + state transitions<br/>
        /// - Tools of LLM (no state) = general tools<br/>
        /// Example: [{"type":"end_call","name":"end_call","description":"End the call with user."}]
        /// </summary>
        /// <example>[{"type":"end_call","name":"end_call","description":"End the call with user."}]</example>
        [global::Newtonsoft.Json.JsonProperty("general_tools")]
        public global::System.Collections.Generic.IList<global::G.Tool>? GeneralTools { get; set; }

        /// <summary>
        /// States of the LLM. This is to help reduce prompt length and tool choices when the call can be broken into distinct states. With shorter prompts and less tools, the LLM can better focus and follow the rules, minimizing hallucination. If this field is not set, the agent would only have general prompt and general tools (essentially one state).<br/>
        /// Example: [{"name":"information_collection","state_prompt":"You will follow the steps below to collect information...","edges":[{"destination_state_name":"appointment_booking","description":"Transition to book an appointment."}],"tools":[{"type":"transfer_call","name":"transfer_to_support","description":"Transfer to the support team.","transfer_destination":{"type":"predefined","number":"16175551212","ignore_e164_validation":false},"transfer_option":{"type":"cold_transfer","show_transferee_as_caller":false}}]}, {"name":"appointment_booking","state_prompt":"You will follow the steps below to book an appointment...","tools":[{"type":"book_appointment_cal","name":"book_appointment","description":"Book an annual check up.","cal_api_key":"cal_live_xxxxxxxxxxxx","event_type_id":60444,"timezone":"America/Los_Angeles"}]}]
        /// </summary>
        /// <example>[{"name":"information_collection","state_prompt":"You will follow the steps below to collect information...","edges":[{"destination_state_name":"appointment_booking","description":"Transition to book an appointment."}],"tools":[{"type":"transfer_call","name":"transfer_to_support","description":"Transfer to the support team.","transfer_destination":{"type":"predefined","number":"16175551212","ignore_e164_validation":false},"transfer_option":{"type":"cold_transfer","show_transferee_as_caller":false}}]}, {"name":"appointment_booking","state_prompt":"You will follow the steps below to book an appointment...","tools":[{"type":"book_appointment_cal","name":"book_appointment","description":"Book an annual check up.","cal_api_key":"cal_live_xxxxxxxxxxxx","event_type_id":60444,"timezone":"America/Los_Angeles"}]}]</example>
        [global::Newtonsoft.Json.JsonProperty("states")]
        public global::System.Collections.Generic.IList<global::G.State>? States { get; set; }

        /// <summary>
        /// Name of the starting state. Required if states is not empty.<br/>
        /// Example: information_collection
        /// </summary>
        /// <example>information_collection</example>
        [global::Newtonsoft.Json.JsonProperty("starting_state")]
        public string? StartingState { get; set; }

        /// <summary>
        /// Default dynamic variables represented as key-value pairs of strings. These are injected into your Retell LLM prompt and tool description when specific values are not provided in a request. Only applicable for Retell LLM.<br/>
        /// Example: {"customer_name":"John Doe"}
        /// </summary>
        /// <example>{"customer_name":"John Doe"}</example>
        [global::Newtonsoft.Json.JsonProperty("default_dynamic_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? DefaultDynamicVariables { get; set; }

        /// <summary>
        /// The version of the LLM.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public int? Version { get; set; }

        /// <summary>
        /// A list of MCPs to use for this LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcps")]
        public global::System.Collections.Generic.IList<global::G.Mcp>? Mcps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetellLlmRequestVariant2" /> class.
        /// </summary>
        /// <param name="generalPrompt">
        /// General prompt appended to system prompt no matter what state the agent is in.<br/>
        /// - System prompt (with state) = general prompt + state prompt.<br/>
        /// - System prompt (no state) = general prompt.<br/>
        /// Example: You are ...
        /// </param>
        /// <param name="generalTools">
        /// A list of tools the model may call (to get external knowledge, call API, etc). You can select from some common predefined tools like end call, transfer call, etc; or you can create your own custom tool for the LLM to use.<br/>
        /// - Tools of LLM (with state) = general tools + state tools + state transitions<br/>
        /// - Tools of LLM (no state) = general tools<br/>
        /// Example: [{"type":"end_call","name":"end_call","description":"End the call with user."}]
        /// </param>
        /// <param name="states">
        /// States of the LLM. This is to help reduce prompt length and tool choices when the call can be broken into distinct states. With shorter prompts and less tools, the LLM can better focus and follow the rules, minimizing hallucination. If this field is not set, the agent would only have general prompt and general tools (essentially one state).<br/>
        /// Example: [{"name":"information_collection","state_prompt":"You will follow the steps below to collect information...","edges":[{"destination_state_name":"appointment_booking","description":"Transition to book an appointment."}],"tools":[{"type":"transfer_call","name":"transfer_to_support","description":"Transfer to the support team.","transfer_destination":{"type":"predefined","number":"16175551212","ignore_e164_validation":false},"transfer_option":{"type":"cold_transfer","show_transferee_as_caller":false}}]}, {"name":"appointment_booking","state_prompt":"You will follow the steps below to book an appointment...","tools":[{"type":"book_appointment_cal","name":"book_appointment","description":"Book an annual check up.","cal_api_key":"cal_live_xxxxxxxxxxxx","event_type_id":60444,"timezone":"America/Los_Angeles"}]}]
        /// </param>
        /// <param name="startingState">
        /// Name of the starting state. Required if states is not empty.<br/>
        /// Example: information_collection
        /// </param>
        /// <param name="defaultDynamicVariables">
        /// Default dynamic variables represented as key-value pairs of strings. These are injected into your Retell LLM prompt and tool description when specific values are not provided in a request. Only applicable for Retell LLM.<br/>
        /// Example: {"customer_name":"John Doe"}
        /// </param>
        /// <param name="version">
        /// The version of the LLM.<br/>
        /// Example: 1
        /// </param>
        /// <param name="mcps">
        /// A list of MCPs to use for this LLM.
        /// </param>
        public RetellLlmRequestVariant2(
            string? generalPrompt,
            global::System.Collections.Generic.IList<global::G.Tool>? generalTools,
            global::System.Collections.Generic.IList<global::G.State>? states,
            string? startingState,
            global::System.Collections.Generic.Dictionary<string, string>? defaultDynamicVariables,
            int? version,
            global::System.Collections.Generic.IList<global::G.Mcp>? mcps)
        {
            this.GeneralPrompt = generalPrompt;
            this.GeneralTools = generalTools;
            this.States = states;
            this.StartingState = startingState;
            this.DefaultDynamicVariables = defaultDynamicVariables;
            this.Version = version;
            this.Mcps = mcps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetellLlmRequestVariant2" /> class.
        /// </summary>
        public RetellLlmRequestVariant2()
        {
        }
    }
}