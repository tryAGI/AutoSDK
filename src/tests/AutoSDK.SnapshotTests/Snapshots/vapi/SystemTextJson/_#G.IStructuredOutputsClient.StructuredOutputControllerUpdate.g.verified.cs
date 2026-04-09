//HintName: G.IStructuredOutputsClient.StructuredOutputControllerUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IStructuredOutputsClient
    {
        /// <summary>
        /// Update Structured Output
        /// </summary>
        /// <param name="id"></param>
        /// <param name="schemaOverride"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StructuredOutput> StructuredOutputControllerUpdateAsync(
            string id,
            string schemaOverride,

            global::G.UpdateStructuredOutputDTO request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Structured Output
        /// </summary>
        /// <param name="id"></param>
        /// <param name="schemaOverride"></param>
        /// <param name="type">
        /// This is the type of structured output.<br/>
        /// - 'ai': Uses an LLM to extract structured data from the conversation (default).<br/>
        /// - 'regex': Uses a regex pattern to extract data from the transcript without an LLM.
        /// </param>
        /// <param name="regex">
        /// This is the regex pattern to match against the transcript.<br/>
        /// Only used when type is 'regex'. Supports both raw patterns (e.g. '\d+') and<br/>
        /// regex literal format (e.g. '/\d+/gi'). Uses RE2 syntax for safety.<br/>
        /// The result depends on the schema type:<br/>
        /// - boolean: true if the pattern matches, false otherwise<br/>
        /// - string: the first match or first capture group<br/>
        /// - number/integer: the first match parsed as a number<br/>
        /// - array: all matches
        /// </param>
        /// <param name="model">
        /// This is the model that will be used to extract the structured output.<br/>
        /// To provide your own custom system and user prompts for structured output extraction, populate the messages array with your system and user messages. You can specify liquid templating in your system and user messages.<br/>
        /// Between the system or user messages, you must reference either 'transcript' or 'messages' with the `{{}}` syntax to access the conversation history.<br/>
        /// Between the system or user messages, you must reference a variation of the structured output with the `{{}}` syntax to access the structured output definition.<br/>
        /// i.e.:<br/>
        /// `{{structuredOutput}}`<br/>
        /// `{{structuredOutput.name}}`<br/>
        /// `{{structuredOutput.description}}`<br/>
        /// `{{structuredOutput.schema}}`<br/>
        /// If model is not specified, GPT-4.1 will be used by default for extraction, utilizing default system and user prompts.<br/>
        /// If messages or required fields are not specified, the default system and user prompts will be used.
        /// </param>
        /// <param name="compliancePlan">
        /// Compliance configuration for this output. Only enable overrides if no sensitive data will be stored.<br/>
        /// Example: {"forceStoreOnHipaaEnabled":false}
        /// </param>
        /// <param name="name">
        /// This is the name of the structured output.
        /// </param>
        /// <param name="description">
        /// This is the description of what the structured output extracts.<br/>
        /// Use this to provide context about what data will be extracted and how it will be used.
        /// </param>
        /// <param name="assistantIds">
        /// These are the assistant IDs that this structured output is linked to.<br/>
        /// When linked to assistants, this structured output will be available for extraction during those assistant's calls.
        /// </param>
        /// <param name="workflowIds">
        /// These are the workflow IDs that this structured output is linked to.<br/>
        /// When linked to workflows, this structured output will be available for extraction during those workflow's execution.
        /// </param>
        /// <param name="schema">
        /// This is the JSON Schema definition for the structured output.<br/>
        /// Defines the structure and validation rules for the data that will be extracted. Supports all JSON Schema features including:<br/>
        /// - Objects and nested properties<br/>
        /// - Arrays and array validation<br/>
        /// - String, number, boolean, and null types<br/>
        /// - Enums and const values<br/>
        /// - Validation constraints (min/max, patterns, etc.)<br/>
        /// - Composition with allOf, anyOf, oneOf
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StructuredOutput> StructuredOutputControllerUpdateAsync(
            string id,
            string schemaOverride,
            global::G.UpdateStructuredOutputDTOType? type = default,
            string? regex = default,
            global::G.OneOf<global::G.WorkflowOpenAIModel, global::G.WorkflowAnthropicModel, global::G.WorkflowAnthropicBedrockModel, global::G.WorkflowGoogleModel, global::G.WorkflowCustomModel>? model = default,
            global::G.ComplianceOverride? compliancePlan = default,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? assistantIds = default,
            global::System.Collections.Generic.IList<string>? workflowIds = default,
            global::G.JsonSchema? schema = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}