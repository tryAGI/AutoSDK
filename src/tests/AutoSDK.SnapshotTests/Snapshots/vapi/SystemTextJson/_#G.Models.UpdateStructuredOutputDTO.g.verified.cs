//HintName: G.Models.UpdateStructuredOutputDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateStructuredOutputDTO
    {
        /// <summary>
        /// This is the type of structured output.<br/>
        /// - 'ai': Uses an LLM to extract structured data from the conversation (default).<br/>
        /// - 'regex': Uses a regex pattern to extract data from the transcript without an LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateStructuredOutputDTOTypeJsonConverter))]
        public global::G.UpdateStructuredOutputDTOType? Type { get; set; }

        /// <summary>
        /// This is the regex pattern to match against the transcript.<br/>
        /// Only used when type is 'regex'. Supports both raw patterns (e.g. '\d+') and<br/>
        /// regex literal format (e.g. '/\d+/gi'). Uses RE2 syntax for safety.<br/>
        /// The result depends on the schema type:<br/>
        /// - boolean: true if the pattern matches, false otherwise<br/>
        /// - string: the first match or first capture group<br/>
        /// - number/integer: the first match parsed as a number<br/>
        /// - array: all matches
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex")]
        public string? Regex { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.WorkflowOpenAIModel, global::G.WorkflowAnthropicModel, global::G.WorkflowAnthropicBedrockModel, global::G.WorkflowGoogleModel, global::G.WorkflowCustomModel>))]
        public global::G.OneOf<global::G.WorkflowOpenAIModel, global::G.WorkflowAnthropicModel, global::G.WorkflowAnthropicBedrockModel, global::G.WorkflowGoogleModel, global::G.WorkflowCustomModel>? Model { get; set; }

        /// <summary>
        /// Compliance configuration for this output. Only enable overrides if no sensitive data will be stored.<br/>
        /// Example: {"forceStoreOnHipaaEnabled":false}
        /// </summary>
        /// <example>{"forceStoreOnHipaaEnabled":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("compliancePlan")]
        public global::G.ComplianceOverride? CompliancePlan { get; set; }

        /// <summary>
        /// This is the name of the structured output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the description of what the structured output extracts.<br/>
        /// Use this to provide context about what data will be extracted and how it will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// These are the assistant IDs that this structured output is linked to.<br/>
        /// When linked to assistants, this structured output will be available for extraction during those assistant's calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantIds")]
        public global::System.Collections.Generic.IList<string>? AssistantIds { get; set; }

        /// <summary>
        /// These are the workflow IDs that this structured output is linked to.<br/>
        /// When linked to workflows, this structured output will be available for extraction during those workflow's execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowIds")]
        public global::System.Collections.Generic.IList<string>? WorkflowIds { get; set; }

        /// <summary>
        /// This is the JSON Schema definition for the structured output.<br/>
        /// Defines the structure and validation rules for the data that will be extracted. Supports all JSON Schema features including:<br/>
        /// - Objects and nested properties<br/>
        /// - Arrays and array validation<br/>
        /// - String, number, boolean, and null types<br/>
        /// - Enums and const values<br/>
        /// - Validation constraints (min/max, patterns, etc.)<br/>
        /// - Composition with allOf, anyOf, oneOf
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public global::G.JsonSchema? Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStructuredOutputDTO" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateStructuredOutputDTO(
            global::G.UpdateStructuredOutputDTOType? type,
            string? regex,
            global::G.OneOf<global::G.WorkflowOpenAIModel, global::G.WorkflowAnthropicModel, global::G.WorkflowAnthropicBedrockModel, global::G.WorkflowGoogleModel, global::G.WorkflowCustomModel>? model,
            global::G.ComplianceOverride? compliancePlan,
            string? name,
            string? description,
            global::System.Collections.Generic.IList<string>? assistantIds,
            global::System.Collections.Generic.IList<string>? workflowIds,
            global::G.JsonSchema? schema)
        {
            this.Type = type;
            this.Regex = regex;
            this.Model = model;
            this.CompliancePlan = compliancePlan;
            this.Name = name;
            this.Description = description;
            this.AssistantIds = assistantIds;
            this.WorkflowIds = workflowIds;
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStructuredOutputDTO" /> class.
        /// </summary>
        public UpdateStructuredOutputDTO()
        {
        }
    }
}