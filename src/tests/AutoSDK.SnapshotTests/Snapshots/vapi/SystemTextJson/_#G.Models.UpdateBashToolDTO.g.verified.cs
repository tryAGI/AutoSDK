//HintName: G.Models.UpdateBashToolDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateBashToolDTO
    {
        /// <summary>
        /// These are the messages that will be spoken to the user as the tool is running.<br/>
        /// For some tools, this is auto-filled based on special fields like `tool.destinations`. For others like the function tool, these can be custom configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ToolMessageStart, global::G.ToolMessageComplete, global::G.ToolMessageFailed, global::G.ToolMessageDelayed>>? Messages { get; set; }

        /// <summary>
        /// The sub type of tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateBashToolDTOSubTypeJsonConverter))]
        public global::G.UpdateBashToolDTOSubType? SubType { get; set; }

        /// <summary>
        ///   This is the server where a `tool-calls` webhook will be sent.<br/>
        ///   Notes:<br/>
        ///   - Webhook is sent to this server when a tool call is made.<br/>
        ///   - Webhook contains the call, assistant, and phone number objects.<br/>
        ///   - Webhook contains the variables set on the assistant.<br/>
        ///   - Webhook is sent to the first available URL in this order: {{tool.server.url}}, {{assistant.server.url}}, {{phoneNumber.server.url}}, {{org.server.url}}.<br/>
        ///   - Webhook expects a response with tool call result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public global::G.Server? Server { get; set; }

        /// <summary>
        /// This is the plan to reject a tool call based on the conversation state.<br/>
        /// // Example 1: Reject endCall if user didn't say goodbye<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'regex',<br/>
        ///     regex: '(?i)\\b(bye|goodbye|farewell|see you later|take care)\\b',<br/>
        ///     target: { position: -1, role: 'user' },<br/>
        ///     negate: true  // Reject if pattern does NOT match<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```<br/>
        /// // Example 2: Reject transfer if user is actually asking a question<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'regex',<br/>
        ///     regex: '\\?',<br/>
        ///     target: { position: -1, role: 'user' }<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```<br/>
        /// // Example 3: Reject transfer if user didn't mention transfer recently<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'liquid',<br/>
        ///     liquid: `{% assign recentMessages = messages | last: 5 %}<br/>
        /// {% assign userMessages = recentMessages | where: 'role', 'user' %}<br/>
        /// {% assign mentioned = false %}<br/>
        /// {% for msg in userMessages %}<br/>
        ///   {% if msg.content contains 'transfer' or msg.content contains 'connect' or msg.content contains 'speak to' %}<br/>
        ///     {% assign mentioned = true %}<br/>
        ///     {% break %}<br/>
        ///   {% endif %}<br/>
        /// {% endfor %}<br/>
        /// {% if mentioned %}<br/>
        ///   false<br/>
        /// {% else %}<br/>
        ///   true<br/>
        /// {% endif %}`<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```<br/>
        /// // Example 4: Reject endCall if the bot is looping and trying to exit<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'liquid',<br/>
        ///     liquid: `{% assign recentMessages = messages | last: 6 %}<br/>
        /// {% assign userMessages = recentMessages | where: 'role', 'user' | reverse %}<br/>
        /// {% if userMessages.size &lt; 3 %}<br/>
        ///   false<br/>
        /// {% else %}<br/>
        ///   {% assign msg1 = userMessages[0].content | downcase %}<br/>
        ///   {% assign msg2 = userMessages[1].content | downcase %}<br/>
        ///   {% assign msg3 = userMessages[2].content | downcase %}<br/>
        ///   {% comment %} Check for repetitive messages {% endcomment %}<br/>
        ///   {% if msg1 == msg2 or msg1 == msg3 or msg2 == msg3 %}<br/>
        ///     true<br/>
        ///   {% comment %} Check for common loop phrases {% endcomment %}<br/>
        ///   {% elsif msg1 contains 'cool thanks' or msg2 contains 'cool thanks' or msg3 contains 'cool thanks' %}<br/>
        ///     true<br/>
        ///   {% elsif msg1 contains 'okay thanks' or msg2 contains 'okay thanks' or msg3 contains 'okay thanks' %}<br/>
        ///     true<br/>
        ///   {% elsif msg1 contains 'got it' or msg2 contains 'got it' or msg3 contains 'got it' %}<br/>
        ///     true<br/>
        ///   {% else %}<br/>
        ///     false<br/>
        ///   {% endif %}<br/>
        /// {% endif %}`<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejectionPlan")]
        public global::G.ToolRejectionPlan? RejectionPlan { get; set; }

        /// <summary>
        /// The name of the tool, fixed to 'bash'<br/>
        /// Default Value: bash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateBashToolDTONameJsonConverter))]
        public global::G.UpdateBashToolDTOName? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBashToolDTO" /> class.
        /// </summary>
        /// <param name="messages">
        /// These are the messages that will be spoken to the user as the tool is running.<br/>
        /// For some tools, this is auto-filled based on special fields like `tool.destinations`. For others like the function tool, these can be custom configured.
        /// </param>
        /// <param name="subType">
        /// The sub type of tool.
        /// </param>
        /// <param name="server">
        ///   This is the server where a `tool-calls` webhook will be sent.<br/>
        ///   Notes:<br/>
        ///   - Webhook is sent to this server when a tool call is made.<br/>
        ///   - Webhook contains the call, assistant, and phone number objects.<br/>
        ///   - Webhook contains the variables set on the assistant.<br/>
        ///   - Webhook is sent to the first available URL in this order: {{tool.server.url}}, {{assistant.server.url}}, {{phoneNumber.server.url}}, {{org.server.url}}.<br/>
        ///   - Webhook expects a response with tool call result.
        /// </param>
        /// <param name="rejectionPlan">
        /// This is the plan to reject a tool call based on the conversation state.<br/>
        /// // Example 1: Reject endCall if user didn't say goodbye<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'regex',<br/>
        ///     regex: '(?i)\\b(bye|goodbye|farewell|see you later|take care)\\b',<br/>
        ///     target: { position: -1, role: 'user' },<br/>
        ///     negate: true  // Reject if pattern does NOT match<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```<br/>
        /// // Example 2: Reject transfer if user is actually asking a question<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'regex',<br/>
        ///     regex: '\\?',<br/>
        ///     target: { position: -1, role: 'user' }<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```<br/>
        /// // Example 3: Reject transfer if user didn't mention transfer recently<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'liquid',<br/>
        ///     liquid: `{% assign recentMessages = messages | last: 5 %}<br/>
        /// {% assign userMessages = recentMessages | where: 'role', 'user' %}<br/>
        /// {% assign mentioned = false %}<br/>
        /// {% for msg in userMessages %}<br/>
        ///   {% if msg.content contains 'transfer' or msg.content contains 'connect' or msg.content contains 'speak to' %}<br/>
        ///     {% assign mentioned = true %}<br/>
        ///     {% break %}<br/>
        ///   {% endif %}<br/>
        /// {% endfor %}<br/>
        /// {% if mentioned %}<br/>
        ///   false<br/>
        /// {% else %}<br/>
        ///   true<br/>
        /// {% endif %}`<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```<br/>
        /// // Example 4: Reject endCall if the bot is looping and trying to exit<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'liquid',<br/>
        ///     liquid: `{% assign recentMessages = messages | last: 6 %}<br/>
        /// {% assign userMessages = recentMessages | where: 'role', 'user' | reverse %}<br/>
        /// {% if userMessages.size &lt; 3 %}<br/>
        ///   false<br/>
        /// {% else %}<br/>
        ///   {% assign msg1 = userMessages[0].content | downcase %}<br/>
        ///   {% assign msg2 = userMessages[1].content | downcase %}<br/>
        ///   {% assign msg3 = userMessages[2].content | downcase %}<br/>
        ///   {% comment %} Check for repetitive messages {% endcomment %}<br/>
        ///   {% if msg1 == msg2 or msg1 == msg3 or msg2 == msg3 %}<br/>
        ///     true<br/>
        ///   {% comment %} Check for common loop phrases {% endcomment %}<br/>
        ///   {% elsif msg1 contains 'cool thanks' or msg2 contains 'cool thanks' or msg3 contains 'cool thanks' %}<br/>
        ///     true<br/>
        ///   {% elsif msg1 contains 'okay thanks' or msg2 contains 'okay thanks' or msg3 contains 'okay thanks' %}<br/>
        ///     true<br/>
        ///   {% elsif msg1 contains 'got it' or msg2 contains 'got it' or msg3 contains 'got it' %}<br/>
        ///     true<br/>
        ///   {% else %}<br/>
        ///     false<br/>
        ///   {% endif %}<br/>
        /// {% endif %}`<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```
        /// </param>
        /// <param name="name">
        /// The name of the tool, fixed to 'bash'<br/>
        /// Default Value: bash
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateBashToolDTO(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ToolMessageStart, global::G.ToolMessageComplete, global::G.ToolMessageFailed, global::G.ToolMessageDelayed>>? messages,
            global::G.UpdateBashToolDTOSubType? subType,
            global::G.Server? server,
            global::G.ToolRejectionPlan? rejectionPlan,
            global::G.UpdateBashToolDTOName? name)
        {
            this.Messages = messages;
            this.SubType = subType;
            this.Server = server;
            this.RejectionPlan = rejectionPlan;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBashToolDTO" /> class.
        /// </summary>
        public UpdateBashToolDTO()
        {
        }
    }
}