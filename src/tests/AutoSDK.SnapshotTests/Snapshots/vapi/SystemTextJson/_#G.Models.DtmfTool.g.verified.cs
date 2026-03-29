//HintName: G.Models.DtmfTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DtmfTool
    {
        /// <summary>
        /// These are the messages that will be spoken to the user as the tool is running.<br/>
        /// For some tools, this is auto-filled based on special fields like `tool.destinations`. For others like the function tool, these can be custom configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ToolMessageStart, global::G.ToolMessageComplete, global::G.ToolMessageFailed, global::G.ToolMessageDelayed>>? Messages { get; set; }

        /// <summary>
        /// The type of tool. "dtmf" for DTMF tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DtmfToolTypeJsonConverter))]
        public global::G.DtmfToolType Type { get; set; }

        /// <summary>
        /// This enables sending DTMF tones via SIP INFO messages instead of RFC 2833 (RTP events). When enabled, DTMF digits will be sent using the SIP INFO method, which can be more reliable in some network configurations. Only relevant when using the `vapi.sip` transport.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sipInfoDtmfEnabled")]
        public bool? SipInfoDtmfEnabled { get; set; }

        /// <summary>
        /// This is the unique identifier for the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the organization that this tool belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the tool was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the tool was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DtmfTool" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the tool.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the organization that this tool belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the tool was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the tool was last updated.
        /// </param>
        /// <param name="messages">
        /// These are the messages that will be spoken to the user as the tool is running.<br/>
        /// For some tools, this is auto-filled based on special fields like `tool.destinations`. For others like the function tool, these can be custom configured.
        /// </param>
        /// <param name="type">
        /// The type of tool. "dtmf" for DTMF tool.
        /// </param>
        /// <param name="sipInfoDtmfEnabled">
        /// This enables sending DTMF tones via SIP INFO messages instead of RFC 2833 (RTP events). When enabled, DTMF digits will be sent using the SIP INFO method, which can be more reliable in some network configurations. Only relevant when using the `vapi.sip` transport.<br/>
        /// Default Value: false
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DtmfTool(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ToolMessageStart, global::G.ToolMessageComplete, global::G.ToolMessageFailed, global::G.ToolMessageDelayed>>? messages,
            global::G.DtmfToolType type,
            bool? sipInfoDtmfEnabled,
            global::G.ToolRejectionPlan? rejectionPlan)
        {
            this.Messages = messages;
            this.Type = type;
            this.SipInfoDtmfEnabled = sipInfoDtmfEnabled;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.RejectionPlan = rejectionPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtmfTool" /> class.
        /// </summary>
        public DtmfTool()
        {
        }
    }
}