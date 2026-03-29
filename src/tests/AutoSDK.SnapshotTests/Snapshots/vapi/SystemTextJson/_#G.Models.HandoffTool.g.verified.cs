//HintName: G.Models.HandoffTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HandoffTool
    {
        /// <summary>
        /// These are the messages that will be spoken to the user as the tool is running.<br/>
        /// For some tools, this is auto-filled based on special fields like `tool.destinations`. For others like the function tool, these can be custom configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ToolMessageStart, global::G.ToolMessageComplete, global::G.ToolMessageFailed, global::G.ToolMessageDelayed>>? Messages { get; set; }

        /// <summary>
        /// This is the type of the tool.<br/>
        /// When you're using handoff tool, we recommend adding this to your system prompt<br/>
        /// ---<br/>
        /// # System context<br/>
        /// You are part of a multi-agent system designed to make agent coordination and execution easy. Agents uses two primary abstraction: **Agents** and **Handoffs**. An agent encompasses instructions and tools and can hand off a conversation to another agent when appropriate. Handoffs are achieved by calling a handoff function, generally named `handoff_to_&lt;agent_name&gt;`. Handoffs between agents are handled seamlessly in the background; do not mention or draw attention to these handoffs in your conversation with the user.<br/>
        /// # Agent context<br/>
        /// {put your agent system prompt here}<br/>
        /// ---
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HandoffToolTypeJsonConverter))]
        public global::G.HandoffToolType Type { get; set; }

        /// <summary>
        /// This is the default local tool result message used when no runtime handoff result override is returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultResult")]
        public string? DefaultResult { get; set; }

        /// <summary>
        /// These are the destinations that the call can be handed off to.<br/>
        /// Usage:<br/>
        /// 1. Single destination<br/>
        /// Use `assistantId` to handoff the call to a saved assistant, or `assistantName` to handoff the call to an assistant in the same squad.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "tools": [<br/>
        ///     {<br/>
        ///       "type": "handoff",<br/>
        ///       "destinations": [<br/>
        ///         {<br/>
        ///           "type": "assistant",<br/>
        ///           "assistantId": "assistant-123", // or "assistantName": "Assistant123"<br/>
        ///           "description": "customer wants to be handed off to assistant-123",<br/>
        ///           "contextEngineeringPlan": {<br/>
        ///             "type": "all"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// 2. Multiple destinations<br/>
        /// 2.1. Multiple Tools, Each With One Destination (OpenAI recommended)<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "tools": [<br/>
        ///     {<br/>
        ///       "type": "handoff",<br/>
        ///       "destinations": [<br/>
        ///         {<br/>
        ///           "type": "assistant",<br/>
        ///           "assistantId": "assistant-123",<br/>
        ///           "description": "customer wants to be handed off to assistant-123",<br/>
        ///           "contextEngineeringPlan": {<br/>
        ///             "type": "all"<br/>
        ///           }<br/>
        ///         },<br/>
        ///       ],<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "type": "handoff",<br/>
        ///       "destinations": [<br/>
        ///         {<br/>
        ///           "type": "assistant",<br/>
        ///           "assistantId": "assistant-456",<br/>
        ///           "description": "customer wants to be handed off to assistant-456",<br/>
        ///           "contextEngineeringPlan": {<br/>
        ///             "type": "all"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// 2.2. One Tool, Multiple Destinations (Anthropic recommended)<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "tools": [<br/>
        ///     {<br/>
        ///       "type": "handoff",<br/>
        ///       "destinations": [<br/>
        ///         {<br/>
        ///           "type": "assistant",<br/>
        ///           "assistantId": "assistant-123",<br/>
        ///           "description": "customer wants to be handed off to assistant-123",<br/>
        ///           "contextEngineeringPlan": {<br/>
        ///             "type": "all"<br/>
        ///           }<br/>
        ///         },<br/>
        ///         {<br/>
        ///           "type": "assistant",<br/>
        ///           "assistantId": "assistant-456",<br/>
        ///           "description": "customer wants to be handed off to assistant-456",<br/>
        ///           "contextEngineeringPlan": {<br/>
        ///             "type": "all"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// 3. Dynamic destination<br/>
        /// 3.1 To determine the destination dynamically, supply a `dynamic` handoff destination type and a `server` object.<br/>
        ///     VAPI will send a handoff-destination-request webhook to the `server.url`.<br/>
        ///     The response from the server will be used as the destination (if valid).<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "tools": [<br/>
        ///     {<br/>
        ///       "type": "handoff",<br/>
        ///       "destinations": [<br/>
        ///         {<br/>
        ///           "type": "dynamic",<br/>
        ///           "server": {<br/>
        ///             "url": "https://example.com"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// 3.2. To pass custom parameters to the server, you can use the `function` object.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "tools": [<br/>
        ///     {<br/>
        ///       "type": "handoff",<br/>
        ///       "destinations": [<br/>
        ///         {<br/>
        ///           "type": "dynamic",<br/>
        ///           "server": {<br/>
        ///             "url": "https://example.com"<br/>
        ///           },<br/>
        ///         }<br/>
        ///       ],<br/>
        ///       "function": {<br/>
        ///         "name": "handoff",<br/>
        ///         "description": "Call this function when the customer is ready to be handed off to the next assistant",<br/>
        ///         "parameters": {<br/>
        ///           "type": "object",<br/>
        ///           "properties": {<br/>
        ///             "destination": {<br/>
        ///               "type": "string",<br/>
        ///               "description": "Use dynamic when customer is ready to be handed off to the next assistant",<br/>
        ///               "enum": ["dynamic"]<br/>
        ///             },<br/>
        ///             "customerAreaCode": {<br/>
        ///               "type": "number",<br/>
        ///               "description": "Area code of the customer"<br/>
        ///             },<br/>
        ///             "customerIntent": {<br/>
        ///               "type": "string",<br/>
        ///               "enum": ["new-customer", "existing-customer"],<br/>
        ///               "description": "Use new-customer when customer is a new customer, existing-customer when customer is an existing customer"<br/>
        ///             },<br/>
        ///             "customerSentiment": {<br/>
        ///               "type": "string",<br/>
        ///               "enum": ["positive", "negative", "neutral"],<br/>
        ///               "description": "Use positive when customer is happy, negative when customer is unhappy, neutral when customer is neutral"<br/>
        ///             }<br/>
        ///           }<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// The properties `customerAreaCode`, `customerIntent`, and `customerSentiment` will be passed to the server in the webhook request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinations")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.HandoffDestinationAssistant, global::G.HandoffDestinationDynamic, global::G.HandoffDestinationSquad>>? Destinations { get; set; }

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
        /// This is the optional function definition that will be passed to the LLM.<br/>
        /// If this is not defined, we will construct this based on the other properties.<br/>
        /// For example, given the following tools definition:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "tools": [<br/>
        ///     {<br/>
        ///       "type": "handoff",<br/>
        ///       "destinations": [<br/>
        ///         {<br/>
        ///           "type": "assistant",<br/>
        ///           "assistantId": "assistant-123",<br/>
        ///           "description": "customer wants to be handed off to assistant-123",<br/>
        ///           "contextEngineeringPlan": {<br/>
        ///             "type": "all"<br/>
        ///           }<br/>
        ///         },<br/>
        ///         {<br/>
        ///           "type": "assistant",<br/>
        ///           "assistantId": "assistant-456",<br/>
        ///           "description": "customer wants to be handed off to assistant-456",<br/>
        ///           "contextEngineeringPlan": {<br/>
        ///             "type": "all"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// We will construct the following function definition:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "function": {<br/>
        ///     "name": "handoff_to_assistant-123",<br/>
        ///     "description": "<br/>
        ///          Use this function to handoff the call to the next assistant.<br/>
        ///          Only use it when instructions explicitly ask you to use the handoff_to_assistant function.<br/>
        ///          DO NOT call this function unless you are instructed to do so.<br/>
        ///          Here are the destinations you can handoff the call to:<br/>
        ///          1. assistant-123. When: customer wants to be handed off to assistant-123<br/>
        ///          2. assistant-456. When: customer wants to be handed off to assistant-456<br/>
        ///     ",<br/>
        ///     "parameters": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "destination": {<br/>
        ///           "type": "string",<br/>
        ///           "description": "Options: assistant-123 (customer wants to be handed off to assistant-123), assistant-456 (customer wants to be handed off to assistant-456)",<br/>
        ///           "enum": ["assistant-123", "assistant-456"]<br/>
        ///         },<br/>
        ///       },<br/>
        ///       "required": ["destination"]<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// To override this function, please provide an OpenAI function definition and refer to it in the system prompt.<br/>
        /// You may override parts of the function definition (i.e. you may only want to change the function name for your prompt).<br/>
        /// If you choose to override the function parameters, it must include `destination` as a required parameter, and it must evaluate to either an assistantId, assistantName, or a the string literal `dynamic`.<br/>
        /// To pass custom parameters to the server in a dynamic handoff, you can use the function parameters, with `dynamic` as the destination.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "function": {<br/>
        ///     "name": "dynamic_handoff",<br/>
        ///     "description": "<br/>
        ///          Call this function when the customer is ready to be handed off to the next assistant<br/>
        ///     ",<br/>
        ///     "parameters": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "destination": {<br/>
        ///           "type": "string",<br/>
        ///           "enum": ["dynamic"]<br/>
        ///         },<br/>
        ///         "customerAreaCode": {<br/>
        ///           "type": "number",<br/>
        ///           "description": "Area code of the customer"<br/>
        ///         },<br/>
        ///         "customerIntent": {<br/>
        ///           "type": "string",<br/>
        ///           "enum": ["new-customer", "existing-customer"],<br/>
        ///           "description": "Use new-customer when customer is a new customer, existing-customer when customer is an existing customer"<br/>
        ///         },<br/>
        ///         "customerSentiment": {<br/>
        ///           "type": "string",<br/>
        ///           "enum": ["positive", "negative", "neutral"],<br/>
        ///           "description": "Use positive when customer is happy, negative when customer is unhappy, neutral when customer is neutral"<br/>
        ///         }<br/>
        ///       },<br/>
        ///       "required": ["destination", "customerAreaCode", "customerIntent", "customerSentiment"]<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::G.OpenAIFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HandoffTool" /> class.
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
        /// This is the type of the tool.<br/>
        /// When you're using handoff tool, we recommend adding this to your system prompt<br/>
        /// ---<br/>
        /// # System context<br/>
        /// You are part of a multi-agent system designed to make agent coordination and execution easy. Agents uses two primary abstraction: **Agents** and **Handoffs**. An agent encompasses instructions and tools and can hand off a conversation to another agent when appropriate. Handoffs are achieved by calling a handoff function, generally named `handoff_to_&lt;agent_name&gt;`. Handoffs between agents are handled seamlessly in the background; do not mention or draw attention to these handoffs in your conversation with the user.<br/>
        /// # Agent context<br/>
        /// {put your agent system prompt here}<br/>
        /// ---
        /// </param>
        /// <param name="defaultResult">
        /// This is the default local tool result message used when no runtime handoff result override is returned.
        /// </param>
        /// <param name="destinations">
        /// These are the destinations that the call can be handed off to.<br/>
        /// Usage:<br/>
        /// 1. Single destination<br/>
        /// Use `assistantId` to handoff the call to a saved assistant, or `assistantName` to handoff the call to an assistant in the same squad.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "tools": [<br/>
        ///     {<br/>
        ///       "type": "handoff",<br/>
        ///       "destinations": [<br/>
        ///         {<br/>
        ///           "type": "assistant",<br/>
        ///           "assistantId": "assistant-123", // or "assistantName": "Assistant123"<br/>
        ///           "description": "customer wants to be handed off to assistant-123",<br/>
        ///           "contextEngineeringPlan": {<br/>
        ///             "type": "all"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// 2. Multiple destinations<br/>
        /// 2.1. Multiple Tools, Each With One Destination (OpenAI recommended)<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "tools": [<br/>
        ///     {<br/>
        ///       "type": "handoff",<br/>
        ///       "destinations": [<br/>
        ///         {<br/>
        ///           "type": "assistant",<br/>
        ///           "assistantId": "assistant-123",<br/>
        ///           "description": "customer wants to be handed off to assistant-123",<br/>
        ///           "contextEngineeringPlan": {<br/>
        ///             "type": "all"<br/>
        ///           }<br/>
        ///         },<br/>
        ///       ],<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "type": "handoff",<br/>
        ///       "destinations": [<br/>
        ///         {<br/>
        ///           "type": "assistant",<br/>
        ///           "assistantId": "assistant-456",<br/>
        ///           "description": "customer wants to be handed off to assistant-456",<br/>
        ///           "contextEngineeringPlan": {<br/>
        ///             "type": "all"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// 2.2. One Tool, Multiple Destinations (Anthropic recommended)<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "tools": [<br/>
        ///     {<br/>
        ///       "type": "handoff",<br/>
        ///       "destinations": [<br/>
        ///         {<br/>
        ///           "type": "assistant",<br/>
        ///           "assistantId": "assistant-123",<br/>
        ///           "description": "customer wants to be handed off to assistant-123",<br/>
        ///           "contextEngineeringPlan": {<br/>
        ///             "type": "all"<br/>
        ///           }<br/>
        ///         },<br/>
        ///         {<br/>
        ///           "type": "assistant",<br/>
        ///           "assistantId": "assistant-456",<br/>
        ///           "description": "customer wants to be handed off to assistant-456",<br/>
        ///           "contextEngineeringPlan": {<br/>
        ///             "type": "all"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// 3. Dynamic destination<br/>
        /// 3.1 To determine the destination dynamically, supply a `dynamic` handoff destination type and a `server` object.<br/>
        ///     VAPI will send a handoff-destination-request webhook to the `server.url`.<br/>
        ///     The response from the server will be used as the destination (if valid).<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "tools": [<br/>
        ///     {<br/>
        ///       "type": "handoff",<br/>
        ///       "destinations": [<br/>
        ///         {<br/>
        ///           "type": "dynamic",<br/>
        ///           "server": {<br/>
        ///             "url": "https://example.com"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// 3.2. To pass custom parameters to the server, you can use the `function` object.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "tools": [<br/>
        ///     {<br/>
        ///       "type": "handoff",<br/>
        ///       "destinations": [<br/>
        ///         {<br/>
        ///           "type": "dynamic",<br/>
        ///           "server": {<br/>
        ///             "url": "https://example.com"<br/>
        ///           },<br/>
        ///         }<br/>
        ///       ],<br/>
        ///       "function": {<br/>
        ///         "name": "handoff",<br/>
        ///         "description": "Call this function when the customer is ready to be handed off to the next assistant",<br/>
        ///         "parameters": {<br/>
        ///           "type": "object",<br/>
        ///           "properties": {<br/>
        ///             "destination": {<br/>
        ///               "type": "string",<br/>
        ///               "description": "Use dynamic when customer is ready to be handed off to the next assistant",<br/>
        ///               "enum": ["dynamic"]<br/>
        ///             },<br/>
        ///             "customerAreaCode": {<br/>
        ///               "type": "number",<br/>
        ///               "description": "Area code of the customer"<br/>
        ///             },<br/>
        ///             "customerIntent": {<br/>
        ///               "type": "string",<br/>
        ///               "enum": ["new-customer", "existing-customer"],<br/>
        ///               "description": "Use new-customer when customer is a new customer, existing-customer when customer is an existing customer"<br/>
        ///             },<br/>
        ///             "customerSentiment": {<br/>
        ///               "type": "string",<br/>
        ///               "enum": ["positive", "negative", "neutral"],<br/>
        ///               "description": "Use positive when customer is happy, negative when customer is unhappy, neutral when customer is neutral"<br/>
        ///             }<br/>
        ///           }<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// The properties `customerAreaCode`, `customerIntent`, and `customerSentiment` will be passed to the server in the webhook request body.
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
        /// <param name="function">
        /// This is the optional function definition that will be passed to the LLM.<br/>
        /// If this is not defined, we will construct this based on the other properties.<br/>
        /// For example, given the following tools definition:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "tools": [<br/>
        ///     {<br/>
        ///       "type": "handoff",<br/>
        ///       "destinations": [<br/>
        ///         {<br/>
        ///           "type": "assistant",<br/>
        ///           "assistantId": "assistant-123",<br/>
        ///           "description": "customer wants to be handed off to assistant-123",<br/>
        ///           "contextEngineeringPlan": {<br/>
        ///             "type": "all"<br/>
        ///           }<br/>
        ///         },<br/>
        ///         {<br/>
        ///           "type": "assistant",<br/>
        ///           "assistantId": "assistant-456",<br/>
        ///           "description": "customer wants to be handed off to assistant-456",<br/>
        ///           "contextEngineeringPlan": {<br/>
        ///             "type": "all"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       ],<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// We will construct the following function definition:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "function": {<br/>
        ///     "name": "handoff_to_assistant-123",<br/>
        ///     "description": "<br/>
        ///          Use this function to handoff the call to the next assistant.<br/>
        ///          Only use it when instructions explicitly ask you to use the handoff_to_assistant function.<br/>
        ///          DO NOT call this function unless you are instructed to do so.<br/>
        ///          Here are the destinations you can handoff the call to:<br/>
        ///          1. assistant-123. When: customer wants to be handed off to assistant-123<br/>
        ///          2. assistant-456. When: customer wants to be handed off to assistant-456<br/>
        ///     ",<br/>
        ///     "parameters": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "destination": {<br/>
        ///           "type": "string",<br/>
        ///           "description": "Options: assistant-123 (customer wants to be handed off to assistant-123), assistant-456 (customer wants to be handed off to assistant-456)",<br/>
        ///           "enum": ["assistant-123", "assistant-456"]<br/>
        ///         },<br/>
        ///       },<br/>
        ///       "required": ["destination"]<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// To override this function, please provide an OpenAI function definition and refer to it in the system prompt.<br/>
        /// You may override parts of the function definition (i.e. you may only want to change the function name for your prompt).<br/>
        /// If you choose to override the function parameters, it must include `destination` as a required parameter, and it must evaluate to either an assistantId, assistantName, or a the string literal `dynamic`.<br/>
        /// To pass custom parameters to the server in a dynamic handoff, you can use the function parameters, with `dynamic` as the destination.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "function": {<br/>
        ///     "name": "dynamic_handoff",<br/>
        ///     "description": "<br/>
        ///          Call this function when the customer is ready to be handed off to the next assistant<br/>
        ///     ",<br/>
        ///     "parameters": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "destination": {<br/>
        ///           "type": "string",<br/>
        ///           "enum": ["dynamic"]<br/>
        ///         },<br/>
        ///         "customerAreaCode": {<br/>
        ///           "type": "number",<br/>
        ///           "description": "Area code of the customer"<br/>
        ///         },<br/>
        ///         "customerIntent": {<br/>
        ///           "type": "string",<br/>
        ///           "enum": ["new-customer", "existing-customer"],<br/>
        ///           "description": "Use new-customer when customer is a new customer, existing-customer when customer is an existing customer"<br/>
        ///         },<br/>
        ///         "customerSentiment": {<br/>
        ///           "type": "string",<br/>
        ///           "enum": ["positive", "negative", "neutral"],<br/>
        ///           "description": "Use positive when customer is happy, negative when customer is unhappy, neutral when customer is neutral"<br/>
        ///         }<br/>
        ///       },<br/>
        ///       "required": ["destination", "customerAreaCode", "customerIntent", "customerSentiment"]<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HandoffTool(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ToolMessageStart, global::G.ToolMessageComplete, global::G.ToolMessageFailed, global::G.ToolMessageDelayed>>? messages,
            global::G.HandoffToolType type,
            string? defaultResult,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.HandoffDestinationAssistant, global::G.HandoffDestinationDynamic, global::G.HandoffDestinationSquad>>? destinations,
            global::G.ToolRejectionPlan? rejectionPlan,
            global::G.OpenAIFunction? function)
        {
            this.Messages = messages;
            this.Type = type;
            this.DefaultResult = defaultResult;
            this.Destinations = destinations;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.RejectionPlan = rejectionPlan;
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HandoffTool" /> class.
        /// </summary>
        public HandoffTool()
        {
        }
    }
}