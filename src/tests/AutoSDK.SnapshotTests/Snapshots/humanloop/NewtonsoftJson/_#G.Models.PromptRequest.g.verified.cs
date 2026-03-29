//HintName: G.Models.PromptRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create or update a Prompt.
    /// </summary>
    public sealed partial class PromptRequest
    {
        /// <summary>
        /// Path of the Prompt, including the name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// ID for an existing Prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The model instance used, e.g. gpt-4.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The provider model endpoint used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// The template for the prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template")]
        public global::System.Collections.Generic.IList<global::G.ChatMessage>? Template { get; set; }

        /// <summary>
        /// The company providing the underlying model service.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxTokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Sampling temperature.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topP")]
        public double? TopP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop")]
        public string? Stop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presencePenalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequencyPenalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("other")]
        public object? Other { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responseFormat")]
        public global::G.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.ToolFunction>? Tools { get; set; }

        /// <summary>
        /// IDs of Tools linked to this prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("linkedTools")]
        public global::System.Collections.Generic.IList<string>? LinkedTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionName")]
        public string? VersionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionDescription")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model instance used, e.g. gpt-4.
        /// </param>
        /// <param name="path">
        /// Path of the Prompt, including the name.
        /// </param>
        /// <param name="id">
        /// ID for an existing Prompt.
        /// </param>
        /// <param name="endpoint">
        /// The provider model endpoint used.
        /// </param>
        /// <param name="template">
        /// The template for the prompt.
        /// </param>
        /// <param name="provider">
        /// The company providing the underlying model service.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature.
        /// </param>
        /// <param name="topP"></param>
        /// <param name="stop"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="other"></param>
        /// <param name="seed"></param>
        /// <param name="responseFormat"></param>
        /// <param name="tools"></param>
        /// <param name="linkedTools">
        /// IDs of Tools linked to this prompt.
        /// </param>
        /// <param name="attributes"></param>
        /// <param name="versionName"></param>
        /// <param name="versionDescription"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="readme"></param>
        public PromptRequest(
            string model,
            string? path,
            string? id,
            string? endpoint,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? template,
            string? provider,
            int? maxTokens,
            double? temperature,
            double? topP,
            string? stop,
            double? presencePenalty,
            double? frequencyPenalty,
            object? other,
            int? seed,
            global::G.ResponseFormat? responseFormat,
            global::System.Collections.Generic.IList<global::G.ToolFunction>? tools,
            global::System.Collections.Generic.IList<string>? linkedTools,
            object? attributes,
            string? versionName,
            string? versionDescription,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            string? readme)
        {
            this.Path = path;
            this.Id = id;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Endpoint = endpoint;
            this.Template = template;
            this.Provider = provider;
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
            this.TopP = topP;
            this.Stop = stop;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.Other = other;
            this.Seed = seed;
            this.ResponseFormat = responseFormat;
            this.Tools = tools;
            this.LinkedTools = linkedTools;
            this.Attributes = attributes;
            this.VersionName = versionName;
            this.VersionDescription = versionDescription;
            this.Description = description;
            this.Tags = tags;
            this.Readme = readme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptRequest" /> class.
        /// </summary>
        public PromptRequest()
        {
        }
    }
}