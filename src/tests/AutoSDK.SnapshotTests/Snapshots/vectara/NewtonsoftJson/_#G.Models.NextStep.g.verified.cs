//HintName: G.Models.NextStep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A conditional transition to another step.
    /// </summary>
    public sealed partial class NextStep
    {
        /// <summary>
        /// UserFn expression evaluating to boolean.<br/>
        /// Uses the `get()` function with JSONPath to access the step transition context.<br/>
        /// See https://docs.vectara.com/docs/search-and-retrieval/rerankers/user-defined-function-reranker for the UserFn language reference.<br/>
        /// Omit for catch-all/default routing.<br/>
        /// The context available to `get()` has the following shape:<br/>
        /// ```<br/>
        /// {<br/>
        ///   "agent": {<br/>
        ///     "name": "...",<br/>
        ///     "key": "...",<br/>
        ///     "description": "...",<br/>
        ///     "metadata": { ... }<br/>
        ///   },<br/>
        ///   "session": {<br/>
        ///     "key": "...",<br/>
        ///     "name": "...",<br/>
        ///     "description": "...",<br/>
        ///     "metadata": { ... }<br/>
        ///   },<br/>
        ///   "currentDate": "2024-01-15T10:35:00Z",<br/>
        ///   "tools": {<br/>
        ///     "&lt;tool_config_name&gt;": {<br/>
        ///       "outputs": {<br/>
        ///         "latest": { ... }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   },<br/>
        ///   "output": { "text": "..." }<br/>
        /// }<br/>
        /// ```<br/>
        /// - `$.agent.metadata.&lt;key&gt;` — agent metadata fields<br/>
        /// - `$.session.metadata.&lt;key&gt;` — session metadata fields<br/>
        /// - `$.tools.&lt;tool_config_name&gt;.outputs.latest.&lt;field&gt;` — latest tool output fields<br/>
        /// - `$.output.text` — LLM text output (when output_parser is `default`)<br/>
        /// - `$.output.&lt;field&gt;` — LLM structured output fields (when output_parser is `structured`)<br/>
        /// Example: get('$.output.intent') == 'sales'
        /// </summary>
        /// <example>get('$.output.intent') == 'sales'</example>
        [global::Newtonsoft.Json.JsonProperty("condition")]
        public string? Condition { get; set; }

        /// <summary>
        /// Name of the step to transition to.<br/>
        /// Must reference a step defined in the agent's steps list.<br/>
        /// Example: sales_handler
        /// </summary>
        /// <example>sales_handler</example>
        [global::Newtonsoft.Json.JsonProperty("step_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string StepName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NextStep" /> class.
        /// </summary>
        /// <param name="condition">
        /// UserFn expression evaluating to boolean.<br/>
        /// Uses the `get()` function with JSONPath to access the step transition context.<br/>
        /// See https://docs.vectara.com/docs/search-and-retrieval/rerankers/user-defined-function-reranker for the UserFn language reference.<br/>
        /// Omit for catch-all/default routing.<br/>
        /// The context available to `get()` has the following shape:<br/>
        /// ```<br/>
        /// {<br/>
        ///   "agent": {<br/>
        ///     "name": "...",<br/>
        ///     "key": "...",<br/>
        ///     "description": "...",<br/>
        ///     "metadata": { ... }<br/>
        ///   },<br/>
        ///   "session": {<br/>
        ///     "key": "...",<br/>
        ///     "name": "...",<br/>
        ///     "description": "...",<br/>
        ///     "metadata": { ... }<br/>
        ///   },<br/>
        ///   "currentDate": "2024-01-15T10:35:00Z",<br/>
        ///   "tools": {<br/>
        ///     "&lt;tool_config_name&gt;": {<br/>
        ///       "outputs": {<br/>
        ///         "latest": { ... }<br/>
        ///       }<br/>
        ///     }<br/>
        ///   },<br/>
        ///   "output": { "text": "..." }<br/>
        /// }<br/>
        /// ```<br/>
        /// - `$.agent.metadata.&lt;key&gt;` — agent metadata fields<br/>
        /// - `$.session.metadata.&lt;key&gt;` — session metadata fields<br/>
        /// - `$.tools.&lt;tool_config_name&gt;.outputs.latest.&lt;field&gt;` — latest tool output fields<br/>
        /// - `$.output.text` — LLM text output (when output_parser is `default`)<br/>
        /// - `$.output.&lt;field&gt;` — LLM structured output fields (when output_parser is `structured`)<br/>
        /// Example: get('$.output.intent') == 'sales'
        /// </param>
        /// <param name="stepName">
        /// Name of the step to transition to.<br/>
        /// Must reference a step defined in the agent's steps list.<br/>
        /// Example: sales_handler
        /// </param>
        public NextStep(
            string stepName,
            string? condition)
        {
            this.StepName = stepName ?? throw new global::System.ArgumentNullException(nameof(stepName));
            this.Condition = condition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NextStep" /> class.
        /// </summary>
        public NextStep()
        {
        }
    }
}