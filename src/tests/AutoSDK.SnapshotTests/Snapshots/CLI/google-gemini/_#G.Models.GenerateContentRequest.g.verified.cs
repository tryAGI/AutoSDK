﻿//HintName: G.Models.GenerateContentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to generate a completion from the model.
    /// </summary>
    public sealed partial class GenerateContentRequest
    {
        /// <summary>
        /// Configuration options for model generation and outputs. Not all parameters may be configurable for every model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generationConfig")]
        public global::G.GenerationConfig? GenerationConfig { get; set; }

        /// <summary>
        /// Required. The content of the current conversation with the model. For single-turn queries, this is a single instance. For multi-turn queries, this is a repeated field that contains conversation history + latest request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public global::System.Collections.Generic.IList<global::G.Content>? Contents { get; set; }

        /// <summary>
        /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content. This will be enforced on the `GenerateContentRequest.contents` and `GenerateContentResponse.candidates`. There should not be more than one setting for each `SafetyCategory` type. The API will block any contents and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_HATE_SPEECH, HARM_CATEGORY_SEXUALLY_EXPLICIT, HARM_CATEGORY_DANGEROUS_CONTENT, HARM_CATEGORY_HARASSMENT are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safetySettings")]
        public global::System.Collections.Generic.IList<global::G.SafetySetting>? SafetySettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentRequest" /> class.
        /// </summary>
        /// <param name="generationConfig">
        /// Configuration options for model generation and outputs. Not all parameters may be configurable for every model.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the current conversation with the model. For single-turn queries, this is a single instance. For multi-turn queries, this is a repeated field that contains conversation history + latest request.
        /// </param>
        /// <param name="safetySettings">
        /// Optional. A list of unique `SafetySetting` instances for blocking unsafe content. This will be enforced on the `GenerateContentRequest.contents` and `GenerateContentResponse.candidates`. There should not be more than one setting for each `SafetyCategory` type. The API will block any contents and responses that fail to meet the thresholds set by these settings. This list overrides the default settings for each `SafetyCategory` specified in the safety_settings. If there is no `SafetySetting` for a given `SafetyCategory` provided in the list, the API will use the default safety setting for that category. Harm categories HARM_CATEGORY_HATE_SPEECH, HARM_CATEGORY_SEXUALLY_EXPLICIT, HARM_CATEGORY_DANGEROUS_CONTENT, HARM_CATEGORY_HARASSMENT are supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateContentRequest(
            global::G.GenerationConfig? generationConfig,
            global::System.Collections.Generic.IList<global::G.Content>? contents,
            global::System.Collections.Generic.IList<global::G.SafetySetting>? safetySettings)
        {
            this.GenerationConfig = generationConfig;
            this.Contents = contents;
            this.SafetySettings = safetySettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateContentRequest" /> class.
        /// </summary>
        public GenerateContentRequest()
        {
        }
    }
}