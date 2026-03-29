//HintName: G.Models.StructuredDataPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredDataPlan
    {
        /// <summary>
        /// These are the messages used to generate the structured data.<br/>
        /// @default: ```<br/>
        /// [<br/>
        ///   {<br/>
        ///     "role": "system",<br/>
        ///     "content": "You are an expert data extractor. You will be given a transcript of a call. Extract structured data per the JSON Schema. DO NOT return anything except the structured data.\n\nJson Schema:\\n{{schema}}\n\nOnly respond with the JSON."<br/>
        ///   },<br/>
        ///   {<br/>
        ///     "role": "user",<br/>
        ///     "content": "Here is the transcript:\n\n{{transcript}}\n\n. Here is the ended reason of the call:\n\n{{endedReason}}\n\n"<br/>
        ///   }<br/>
        /// ]```<br/>
        /// You can customize by providing any messages you want.<br/>
        /// Here are the template variables available:<br/>
        /// - {{transcript}}: the transcript of the call from `call.artifact.transcript`- {{systemPrompt}}: the system prompt of the call from `assistant.model.messages[type=system].content`- {{messages}}: the messages of the call from `assistant.model.messages`- {{schema}}: the schema of the structured data from `structuredDataPlan.schema`- {{endedReason}}: the ended reason of the call from `call.endedReason`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<object>? Messages { get; set; }

        /// <summary>
        /// This determines whether structured data is generated and stored in `call.analysis.structuredData`. Defaults to false.<br/>
        /// Usage:<br/>
        /// - If you want to extract structured data, set this to true and provide a `schema`.<br/>
        /// @default false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// This is the schema of the structured data. The output is stored in `call.analysis.structuredData`.<br/>
        /// Complete guide on JSON Schema can be found [here](https://ajv.js.org/json-schema.html#json-data-type).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public global::G.JsonSchema? Schema { get; set; }

        /// <summary>
        /// This is how long the request is tried before giving up. When request times out, `call.analysis.structuredData` will be empty.<br/>
        /// Usage:<br/>
        /// - To guarantee the structured data is generated, set this value high. Note, this will delay the end of call report in cases where model is slow to respond.<br/>
        /// @default 5 seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredDataPlan" /> class.
        /// </summary>
        /// <param name="messages">
        /// These are the messages used to generate the structured data.<br/>
        /// @default: ```<br/>
        /// [<br/>
        ///   {<br/>
        ///     "role": "system",<br/>
        ///     "content": "You are an expert data extractor. You will be given a transcript of a call. Extract structured data per the JSON Schema. DO NOT return anything except the structured data.\n\nJson Schema:\\n{{schema}}\n\nOnly respond with the JSON."<br/>
        ///   },<br/>
        ///   {<br/>
        ///     "role": "user",<br/>
        ///     "content": "Here is the transcript:\n\n{{transcript}}\n\n. Here is the ended reason of the call:\n\n{{endedReason}}\n\n"<br/>
        ///   }<br/>
        /// ]```<br/>
        /// You can customize by providing any messages you want.<br/>
        /// Here are the template variables available:<br/>
        /// - {{transcript}}: the transcript of the call from `call.artifact.transcript`- {{systemPrompt}}: the system prompt of the call from `assistant.model.messages[type=system].content`- {{messages}}: the messages of the call from `assistant.model.messages`- {{schema}}: the schema of the structured data from `structuredDataPlan.schema`- {{endedReason}}: the ended reason of the call from `call.endedReason`
        /// </param>
        /// <param name="enabled">
        /// This determines whether structured data is generated and stored in `call.analysis.structuredData`. Defaults to false.<br/>
        /// Usage:<br/>
        /// - If you want to extract structured data, set this to true and provide a `schema`.<br/>
        /// @default false
        /// </param>
        /// <param name="schema">
        /// This is the schema of the structured data. The output is stored in `call.analysis.structuredData`.<br/>
        /// Complete guide on JSON Schema can be found [here](https://ajv.js.org/json-schema.html#json-data-type).
        /// </param>
        /// <param name="timeoutSeconds">
        /// This is how long the request is tried before giving up. When request times out, `call.analysis.structuredData` will be empty.<br/>
        /// Usage:<br/>
        /// - To guarantee the structured data is generated, set this value high. Note, this will delay the end of call report in cases where model is slow to respond.<br/>
        /// @default 5 seconds
        /// </param>
        public StructuredDataPlan(
            global::System.Collections.Generic.IList<object>? messages,
            bool? enabled,
            global::G.JsonSchema? schema,
            double? timeoutSeconds)
        {
            this.Messages = messages;
            this.Enabled = enabled;
            this.Schema = schema;
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredDataPlan" /> class.
        /// </summary>
        public StructuredDataPlan()
        {
        }
    }
}