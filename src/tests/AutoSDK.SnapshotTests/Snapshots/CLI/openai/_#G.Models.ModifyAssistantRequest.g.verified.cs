﻿//HintName: G.Models.ModifyAssistantRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModifyAssistantRequest
    {
        /// <summary>
        /// ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models) for descriptions of them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::G.AssistantSupportedModels?>))]
        public global::G.AnyOf<string, global::G.AssistantSupportedModels?>? Model { get; set; }

        /// <summary>
        /// **o-series models only** <br/>
        /// Constrains effort on reasoning for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReasoningEffortJsonConverter))]
        public global::G.ReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// The name of the assistant. The maximum length is 256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the assistant. The maximum length is 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The system instructions that the assistant uses. The maximum length is 256,000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// A list of tool enabled on the assistant. There can be a maximum of 128 tools per assistant. Tools can be of types `code_interpreter`, `file_search`, or `function`.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.AssistantToolsCode, global::G.AssistantToolsFileSearch, global::G.AssistantToolsFunction>>? Tools { get; set; }

        /// <summary>
        /// A set of resources that are used by the assistant's tools. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_resources")]
        public global::G.ModifyAssistantRequestToolResources? ToolResources { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.<br/>
        /// We generally recommend altering this or temperature but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Specifies the format that the model must output. Compatible with [GPT-4o](/docs/models#gpt-4o), [GPT-4 Turbo](/docs/models#gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which ensures the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which ensures the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssistantsApiResponseFormatOptionJsonConverter))]
        public global::G.AssistantsApiResponseFormatOption? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyAssistantRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to see all of your available models, or see our [Model overview](/docs/models) for descriptions of them.
        /// </param>
        /// <param name="reasoningEffort">
        /// **o-series models only** <br/>
        /// Constrains effort on reasoning for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="name">
        /// The name of the assistant. The maximum length is 256 characters.
        /// </param>
        /// <param name="description">
        /// The description of the assistant. The maximum length is 512 characters.
        /// </param>
        /// <param name="instructions">
        /// The system instructions that the assistant uses. The maximum length is 256,000 characters.
        /// </param>
        /// <param name="tools">
        /// A list of tool enabled on the assistant. There can be a maximum of 128 tools per assistant. Tools can be of types `code_interpreter`, `file_search`, or `function`.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="toolResources">
        /// A set of resources that are used by the assistant's tools. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.<br/>
        /// We generally recommend altering this or temperature but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="responseFormat">
        /// Specifies the format that the model must output. Compatible with [GPT-4o](/docs/models#gpt-4o), [GPT-4 Turbo](/docs/models#gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which ensures the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which ensures the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModifyAssistantRequest(
            global::G.AnyOf<string, global::G.AssistantSupportedModels?>? model,
            global::G.ReasoningEffort? reasoningEffort,
            string? name,
            string? description,
            string? instructions,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.AssistantToolsCode, global::G.AssistantToolsFileSearch, global::G.AssistantToolsFunction>>? tools,
            global::G.ModifyAssistantRequestToolResources? toolResources,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            double? temperature,
            double? topP,
            global::G.AssistantsApiResponseFormatOption? responseFormat)
        {
            this.Model = model;
            this.ReasoningEffort = reasoningEffort;
            this.Name = name;
            this.Description = description;
            this.Instructions = instructions;
            this.Tools = tools;
            this.ToolResources = toolResources;
            this.Metadata = metadata;
            this.Temperature = temperature;
            this.TopP = topP;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyAssistantRequest" /> class.
        /// </summary>
        public ModifyAssistantRequest()
        {
        }
    }
}