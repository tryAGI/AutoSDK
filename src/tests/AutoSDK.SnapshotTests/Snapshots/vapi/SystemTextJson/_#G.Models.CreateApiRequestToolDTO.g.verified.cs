//HintName: G.Models.CreateApiRequestToolDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiRequestToolDTO
    {
        /// <summary>
        /// These are the messages that will be spoken to the user as the tool is running.<br/>
        /// For some tools, this is auto-filled based on special fields like `tool.destinations`. For others like the function tool, these can be custom configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ToolMessageStart, global::G.ToolMessageComplete, global::G.ToolMessageFailed, global::G.ToolMessageDelayed>>? Messages { get; set; }

        /// <summary>
        /// The type of tool. "apiRequest" for API request tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateApiRequestToolDTOTypeJsonConverter))]
        public global::G.CreateApiRequestToolDTOType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateApiRequestToolDTOMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateApiRequestToolDTOMethod Method { get; set; }

        /// <summary>
        /// This is the timeout in seconds for the request. Defaults to 20 seconds.<br/>
        /// @default 20<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// The credential ID for API request authentication<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentialId")]
        public string? CredentialId { get; set; }

        /// <summary>
        /// This is the paths to encrypt in the request body if credentialId and encryptionPlan are defined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryptedPaths")]
        public global::System.Collections.Generic.IList<string>? EncryptedPaths { get; set; }

        /// <summary>
        /// Static key-value pairs merged into the request body. Values support Liquid templates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.IList<global::G.ToolParameter>? Parameters { get; set; }

        /// <summary>
        /// This is the name of the tool. This will be passed to the model.<br/>
        /// Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 40.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the description of the tool. This will be passed to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// This is where the request will be sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// This is the body of the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public global::G.JsonSchema? Body { get; set; }

        /// <summary>
        /// These are the headers to send with the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::G.JsonSchema? Headers { get; set; }

        /// <summary>
        /// This is the backoff plan if the request fails. Defaults to undefined (the request will not be retried).<br/>
        /// @default undefined (the request will not be retried)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backoffPlan")]
        public global::G.BackoffPlan? BackoffPlan { get; set; }

        /// <summary>
        /// This is the plan to extract variables from the tool's response. These will be accessible during the call and stored in `call.artifact.variableValues` after the call.<br/>
        /// Usage:<br/>
        /// 1. Use `aliases` to extract variables from the tool's response body. (Most common case)<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "aliases": [<br/>
        ///     {<br/>
        ///       "key": "customerName",<br/>
        ///       "value": "{{customer.name}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "customerAge",<br/>
        ///       "value": "{{customer.age}}"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// The tool response body is made available to the liquid template.<br/>
        /// 2. Use `aliases` to extract variables from the tool's response body if the response is an array.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "aliases": [<br/>
        ///     {<br/>
        ///       "key": "customerName",<br/>
        ///       "value": "{{$[0].name}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "customerAge",<br/>
        ///       "value": "{{$[0].age}}"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// $ is a shorthand for the tool's response body. `$[0]` is the first item in the array. `$[n]` is the nth item in the array. Note, $ is available regardless of the response body type (both object and array).<br/>
        /// 3. Use `aliases` to extract variables from the tool's response headers.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "aliases": [<br/>
        ///     {<br/>
        ///       "key": "customerName",<br/>
        ///       "value": "{{tool.response.headers.customer-name}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "customerAge",<br/>
        ///       "value": "{{tool.response.headers.customer-age}}"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// `tool.response` is made available to the liquid template. Particularly, both `tool.response.headers` and `tool.response.body` are available. Note, `tool.response` is available regardless of the response body type (both object and array).<br/>
        /// 4. Use `schema` to extract a large portion of the tool's response body.<br/>
        /// 4.1. If you hit example.com and it returns `{"name": "John", "age": 30}`, then you can specify the schema as:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "schema": {<br/>
        ///     "type": "object",<br/>
        ///     "properties": {<br/>
        ///       "name": {<br/>
        ///         "type": "string"<br/>
        ///       },<br/>
        ///       "age": {<br/>
        ///         "type": "number"<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// These will be extracted as `{{ name }}` and `{{ age }}` respectively. To emphasize, object properties are extracted as direct global variables.<br/>
        /// 4.2. If you hit example.com and it returns `{"name": {"first": "John", "last": "Doe"}}`, then you can specify the schema as:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "schema": {<br/>
        ///     "type": "object",<br/>
        ///     "properties": {<br/>
        ///       "name": {<br/>
        ///         "type": "object",<br/>
        ///         "properties": {<br/>
        ///           "first": {<br/>
        ///             "type": "string"<br/>
        ///           },<br/>
        ///           "last": {<br/>
        ///             "type": "string"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// These will be extracted as `{{ name }}`. And, `{{ name.first }}` and `{{ name.last }}` will be accessible.<br/>
        /// 4.3. If you hit example.com and it returns `["94123", "94124"]`, then you can specify the schema as:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "schema": {<br/>
        ///     "type": "array",<br/>
        ///     "title": "zipCodes",<br/>
        ///     "items": {<br/>
        ///       "type": "string"<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ zipCodes }}`. To access the array items, you can use `{{ zipCodes[0] }}` and `{{ zipCodes[1] }}`.<br/>
        /// 4.4. If you hit example.com and it returns `[{"name": "John", "age": 30, "zipCodes": ["94123", "94124"]}, {"name": "Jane", "age": 25, "zipCodes": ["94125", "94126"]}]`, then you can specify the schema as:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "schema": {<br/>
        ///     "type": "array",<br/>
        ///     "title": "people",<br/>
        ///     "items": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "name": {<br/>
        ///           "type": "string"<br/>
        ///         },<br/>
        ///         "age": {<br/>
        ///           "type": "number"<br/>
        ///         },<br/>
        ///         "zipCodes": {<br/>
        ///           "type": "array",<br/>
        ///           "items": {<br/>
        ///             "type": "string"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ people }}`. To access the array items, you can use `{{ people[n].name }}`, `{{ people[n].age }}`, `{{ people[n].zipCodes }}`, `{{ people[n].zipCodes[0] }}` and `{{ people[n].zipCodes[1] }}`.<br/>
        /// Note: Both `aliases` and `schema` can be used together.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableExtractionPlan")]
        public global::G.VariableExtractionPlan? VariableExtractionPlan { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateApiRequestToolDTO" /> class.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="url">
        /// This is where the request will be sent.
        /// </param>
        /// <param name="messages">
        /// These are the messages that will be spoken to the user as the tool is running.<br/>
        /// For some tools, this is auto-filled based on special fields like `tool.destinations`. For others like the function tool, these can be custom configured.
        /// </param>
        /// <param name="type">
        /// The type of tool. "apiRequest" for API request tool.
        /// </param>
        /// <param name="timeoutSeconds">
        /// This is the timeout in seconds for the request. Defaults to 20 seconds.<br/>
        /// @default 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="credentialId">
        /// The credential ID for API request authentication<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="encryptedPaths">
        /// This is the paths to encrypt in the request body if credentialId and encryptionPlan are defined.
        /// </param>
        /// <param name="parameters">
        /// Static key-value pairs merged into the request body. Values support Liquid templates.
        /// </param>
        /// <param name="name">
        /// This is the name of the tool. This will be passed to the model.<br/>
        /// Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 40.
        /// </param>
        /// <param name="description">
        /// This is the description of the tool. This will be passed to the model.
        /// </param>
        /// <param name="body">
        /// This is the body of the request.
        /// </param>
        /// <param name="headers">
        /// These are the headers to send with the request.
        /// </param>
        /// <param name="backoffPlan">
        /// This is the backoff plan if the request fails. Defaults to undefined (the request will not be retried).<br/>
        /// @default undefined (the request will not be retried)
        /// </param>
        /// <param name="variableExtractionPlan">
        /// This is the plan to extract variables from the tool's response. These will be accessible during the call and stored in `call.artifact.variableValues` after the call.<br/>
        /// Usage:<br/>
        /// 1. Use `aliases` to extract variables from the tool's response body. (Most common case)<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "aliases": [<br/>
        ///     {<br/>
        ///       "key": "customerName",<br/>
        ///       "value": "{{customer.name}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "customerAge",<br/>
        ///       "value": "{{customer.age}}"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// The tool response body is made available to the liquid template.<br/>
        /// 2. Use `aliases` to extract variables from the tool's response body if the response is an array.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "aliases": [<br/>
        ///     {<br/>
        ///       "key": "customerName",<br/>
        ///       "value": "{{$[0].name}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "customerAge",<br/>
        ///       "value": "{{$[0].age}}"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// $ is a shorthand for the tool's response body. `$[0]` is the first item in the array. `$[n]` is the nth item in the array. Note, $ is available regardless of the response body type (both object and array).<br/>
        /// 3. Use `aliases` to extract variables from the tool's response headers.<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "aliases": [<br/>
        ///     {<br/>
        ///       "key": "customerName",<br/>
        ///       "value": "{{tool.response.headers.customer-name}}"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "key": "customerAge",<br/>
        ///       "value": "{{tool.response.headers.customer-age}}"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// `tool.response` is made available to the liquid template. Particularly, both `tool.response.headers` and `tool.response.body` are available. Note, `tool.response` is available regardless of the response body type (both object and array).<br/>
        /// 4. Use `schema` to extract a large portion of the tool's response body.<br/>
        /// 4.1. If you hit example.com and it returns `{"name": "John", "age": 30}`, then you can specify the schema as:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "schema": {<br/>
        ///     "type": "object",<br/>
        ///     "properties": {<br/>
        ///       "name": {<br/>
        ///         "type": "string"<br/>
        ///       },<br/>
        ///       "age": {<br/>
        ///         "type": "number"<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// These will be extracted as `{{ name }}` and `{{ age }}` respectively. To emphasize, object properties are extracted as direct global variables.<br/>
        /// 4.2. If you hit example.com and it returns `{"name": {"first": "John", "last": "Doe"}}`, then you can specify the schema as:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "schema": {<br/>
        ///     "type": "object",<br/>
        ///     "properties": {<br/>
        ///       "name": {<br/>
        ///         "type": "object",<br/>
        ///         "properties": {<br/>
        ///           "first": {<br/>
        ///             "type": "string"<br/>
        ///           },<br/>
        ///           "last": {<br/>
        ///             "type": "string"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// These will be extracted as `{{ name }}`. And, `{{ name.first }}` and `{{ name.last }}` will be accessible.<br/>
        /// 4.3. If you hit example.com and it returns `["94123", "94124"]`, then you can specify the schema as:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "schema": {<br/>
        ///     "type": "array",<br/>
        ///     "title": "zipCodes",<br/>
        ///     "items": {<br/>
        ///       "type": "string"<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ zipCodes }}`. To access the array items, you can use `{{ zipCodes[0] }}` and `{{ zipCodes[1] }}`.<br/>
        /// 4.4. If you hit example.com and it returns `[{"name": "John", "age": 30, "zipCodes": ["94123", "94124"]}, {"name": "Jane", "age": 25, "zipCodes": ["94125", "94126"]}]`, then you can specify the schema as:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "schema": {<br/>
        ///     "type": "array",<br/>
        ///     "title": "people",<br/>
        ///     "items": {<br/>
        ///       "type": "object",<br/>
        ///       "properties": {<br/>
        ///         "name": {<br/>
        ///           "type": "string"<br/>
        ///         },<br/>
        ///         "age": {<br/>
        ///           "type": "number"<br/>
        ///         },<br/>
        ///         "zipCodes": {<br/>
        ///           "type": "array",<br/>
        ///           "items": {<br/>
        ///             "type": "string"<br/>
        ///           }<br/>
        ///         }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// This will be extracted as `{{ people }}`. To access the array items, you can use `{{ people[n].name }}`, `{{ people[n].age }}`, `{{ people[n].zipCodes }}`, `{{ people[n].zipCodes[0] }}` and `{{ people[n].zipCodes[1] }}`.<br/>
        /// Note: Both `aliases` and `schema` can be used together.
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
        public CreateApiRequestToolDTO(
            global::G.CreateApiRequestToolDTOMethod method,
            string url,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ToolMessageStart, global::G.ToolMessageComplete, global::G.ToolMessageFailed, global::G.ToolMessageDelayed>>? messages,
            global::G.CreateApiRequestToolDTOType type,
            double? timeoutSeconds,
            string? credentialId,
            global::System.Collections.Generic.IList<string>? encryptedPaths,
            global::System.Collections.Generic.IList<global::G.ToolParameter>? parameters,
            string? name,
            string? description,
            global::G.JsonSchema? body,
            global::G.JsonSchema? headers,
            global::G.BackoffPlan? backoffPlan,
            global::G.VariableExtractionPlan? variableExtractionPlan,
            global::G.ToolRejectionPlan? rejectionPlan)
        {
            this.Messages = messages;
            this.Type = type;
            this.Method = method;
            this.TimeoutSeconds = timeoutSeconds;
            this.CredentialId = credentialId;
            this.EncryptedPaths = encryptedPaths;
            this.Parameters = parameters;
            this.Name = name;
            this.Description = description;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Body = body;
            this.Headers = headers;
            this.BackoffPlan = backoffPlan;
            this.VariableExtractionPlan = variableExtractionPlan;
            this.RejectionPlan = rejectionPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiRequestToolDTO" /> class.
        /// </summary>
        public CreateApiRequestToolDTO()
        {
        }
    }
}