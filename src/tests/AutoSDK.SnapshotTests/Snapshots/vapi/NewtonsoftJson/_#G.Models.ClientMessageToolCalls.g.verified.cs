//HintName: G.Models.ClientMessageToolCalls.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientMessageToolCalls
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumber")]
        public global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "tool-calls" is sent to call a tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ClientMessageToolCallsTypeJsonConverter))]
        public global::G.ClientMessageToolCallsType? Type { get; set; }

        /// <summary>
        /// This is the list of tools calls that the model is requesting along with the original tool configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolWithToolCallList", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.FunctionToolWithToolCall, global::G.GhlToolWithToolCall, global::G.MakeToolWithToolCall, global::G.BashToolWithToolCall, global::G.ComputerToolWithToolCall, global::G.TextEditorToolWithToolCall, global::G.GoogleCalendarCreateEventToolWithToolCall>> ToolWithToolCallList { get; set; } = default!;

        /// <summary>
        /// This is the timestamp of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// This is the call that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call")]
        public global::G.Call? Call { get; set; }

        /// <summary>
        /// This is the customer that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customer")]
        public global::G.CreateCustomerDTO? Customer { get; set; }

        /// <summary>
        /// This is the assistant that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// This is the list of tool calls that the model is requesting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolCallList", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ToolCall> ToolCallList { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageToolCalls" /> class.
        /// </summary>
        /// <param name="toolWithToolCallList">
        /// This is the list of tools calls that the model is requesting along with the original tool configuration.
        /// </param>
        /// <param name="toolCallList">
        /// This is the list of tool calls that the model is requesting.
        /// </param>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "tool-calls" is sent to call a tool.
        /// </param>
        /// <param name="timestamp">
        /// This is the timestamp of the message.
        /// </param>
        /// <param name="call">
        /// This is the call that the message is associated with.
        /// </param>
        /// <param name="customer">
        /// This is the customer that the message is associated with.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant that the message is associated with.
        /// </param>
        public ClientMessageToolCalls(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.FunctionToolWithToolCall, global::G.GhlToolWithToolCall, global::G.MakeToolWithToolCall, global::G.BashToolWithToolCall, global::G.ComputerToolWithToolCall, global::G.TextEditorToolWithToolCall, global::G.GoogleCalendarCreateEventToolWithToolCall>> toolWithToolCallList,
            global::System.Collections.Generic.IList<global::G.ToolCall> toolCallList,
            global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::G.ClientMessageToolCallsType? type,
            double? timestamp,
            global::G.Call? call,
            global::G.CreateCustomerDTO? customer,
            global::G.CreateAssistantDTO? assistant)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.ToolWithToolCallList = toolWithToolCallList ?? throw new global::System.ArgumentNullException(nameof(toolWithToolCallList));
            this.Timestamp = timestamp;
            this.Call = call;
            this.Customer = customer;
            this.Assistant = assistant;
            this.ToolCallList = toolCallList ?? throw new global::System.ArgumentNullException(nameof(toolCallList));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageToolCalls" /> class.
        /// </summary>
        public ClientMessageToolCalls()
        {
        }
    }
}