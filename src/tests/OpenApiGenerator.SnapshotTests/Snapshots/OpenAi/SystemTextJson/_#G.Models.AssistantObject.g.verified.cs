//HintName: G.Models.AssistantObject.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an `assistant` that can call the model and use tools.
    /// </summary>
    public sealed partial class AssistantObject
    {
        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `assistant`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AssistantObjectObjectJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AssistantObjectObject Object { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the assistant was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// The name of the assistant. The maximum length is 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Name { get; set; }

        /// <summary>
        /// The description of the assistant. The maximum length is 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models/overview) for descriptions of them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The system instructions that the assistant uses. The maximum length is 256,000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Instructions { get; set; }

        /// <summary>
        /// A list of tool enabled on the assistant. There can be a maximum of 128 tools per assistant. Tools can be of types `code_interpreter`, `file_search`, or `function`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.OneOf<global::G.AssistantToolsCode?, global::G.AssistantToolsFileSearch?, global::G.AssistantToolsFunction?>> Tools { get; set; }

        /// <summary>
        /// A set of resources that are used by the assistant's tools. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_resources")]
        public global::G.AssistantObjectToolResources? ToolResources { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AssistantObjectMetadata? Metadata { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; } = 1;

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.<br/>
        /// We generally recommend altering this or temperature but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; } = 1;

        /// <summary>
        /// Specifies the format that the model must output. Compatible with [GPT-4o](/docs/models/gpt-4o), [GPT-4 Turbo](/docs/models/gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which guarantees the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter))]
        public global::G.AssistantsApiResponseFormatOption? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}