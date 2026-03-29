//HintName: G.Models.PromptResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for a Prompt.
    /// </summary>
    public sealed partial class PromptResponse
    {
        /// <summary>
        /// Path of the Prompt, including the name, which is used as a unique identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the Prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// ID of the directory that the file is in on Humanloop.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("directoryId")]
        public string? DirectoryId { get; set; }

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
        /// The template for the prompt as a list of chat messages.
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
        /// Sampling temperature for generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topP")]
        public double? TopP { get; set; }

        /// <summary>
        /// Stop sequence.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop")]
        public string? Stop { get; set; }

        /// <summary>
        /// Presence penalty value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presencePenalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Frequency penalty value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequencyPenalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Other parameter values to be passed to the provider call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("other")]
        public object? Other { get; set; }

        /// <summary>
        /// Seed for deterministic sampling.
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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("linkedTools")]
        public global::System.Collections.Generic.IList<global::G.LinkedToolResponse>? LinkedTools { get; set; }

        /// <summary>
        /// Additional fields to describe the Prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Unique name for the Prompt version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionName")]
        public string? VersionName { get; set; }

        /// <summary>
        /// Description of the version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionDescription")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// Description of the Prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Long description of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// Name of the Prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Unique identifier for the specific Prompt Version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string VersionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PromptResponseType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environments")]
        public global::System.Collections.Generic.IList<global::G.EnvironmentResponse>? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdBy")]
        public global::G.UserResponse? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUsedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LastUsedAt { get; set; } = default!;

        /// <summary>
        /// The number of logs generated for this Prompt Version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionLogsCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionLogsCount { get; set; } = default!;

        /// <summary>
        /// The number of logs generated across all Prompt Versions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalLogsCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalLogsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.InputResponse> Inputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluators")]
        public global::System.Collections.Generic.IList<global::G.MonitoringEvaluatorResponse>? Evaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluatorAggregates")]
        public global::System.Collections.Generic.IList<global::G.EvaluatorAggregate>? EvaluatorAggregates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptResponse" /> class.
        /// </summary>
        /// <param name="path">
        /// Path of the Prompt, including the name, which is used as a unique identifier.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the Prompt.
        /// </param>
        /// <param name="model">
        /// The model instance used, e.g. gpt-4.
        /// </param>
        /// <param name="name">
        /// Name of the Prompt.
        /// </param>
        /// <param name="versionId">
        /// Unique identifier for the specific Prompt Version.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="lastUsedAt"></param>
        /// <param name="versionLogsCount">
        /// The number of logs generated for this Prompt Version.
        /// </param>
        /// <param name="totalLogsCount">
        /// The number of logs generated across all Prompt Versions.
        /// </param>
        /// <param name="inputs"></param>
        /// <param name="directoryId">
        /// ID of the directory that the file is in on Humanloop.
        /// </param>
        /// <param name="endpoint">
        /// The provider model endpoint used.
        /// </param>
        /// <param name="template">
        /// The template for the prompt as a list of chat messages.
        /// </param>
        /// <param name="provider">
        /// The company providing the underlying model service.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for generation.
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter.
        /// </param>
        /// <param name="stop">
        /// Stop sequence.
        /// </param>
        /// <param name="presencePenalty">
        /// Presence penalty value.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Frequency penalty value.
        /// </param>
        /// <param name="other">
        /// Other parameter values to be passed to the provider call.
        /// </param>
        /// <param name="seed">
        /// Seed for deterministic sampling.
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="tools"></param>
        /// <param name="linkedTools"></param>
        /// <param name="attributes">
        /// Additional fields to describe the Prompt.
        /// </param>
        /// <param name="versionName">
        /// Unique name for the Prompt version.
        /// </param>
        /// <param name="versionDescription">
        /// Description of the version.
        /// </param>
        /// <param name="description">
        /// Description of the Prompt.
        /// </param>
        /// <param name="tags"></param>
        /// <param name="readme">
        /// Long description of the file.
        /// </param>
        /// <param name="schema"></param>
        /// <param name="type"></param>
        /// <param name="environments"></param>
        /// <param name="createdBy"></param>
        /// <param name="evaluators"></param>
        /// <param name="evaluatorAggregates"></param>
        public PromptResponse(
            string path,
            string id,
            string model,
            string name,
            string versionId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime lastUsedAt,
            int versionLogsCount,
            int totalLogsCount,
            global::System.Collections.Generic.IList<global::G.InputResponse> inputs,
            string? directoryId,
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
            global::System.Collections.Generic.IList<global::G.LinkedToolResponse>? linkedTools,
            object? attributes,
            string? versionName,
            string? versionDescription,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            string? readme,
            object? schema,
            global::G.PromptResponseType? type,
            global::System.Collections.Generic.IList<global::G.EnvironmentResponse>? environments,
            global::G.UserResponse? createdBy,
            global::System.Collections.Generic.IList<global::G.MonitoringEvaluatorResponse>? evaluators,
            global::System.Collections.Generic.IList<global::G.EvaluatorAggregate>? evaluatorAggregates)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DirectoryId = directoryId;
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
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Schema = schema;
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.Type = type;
            this.Environments = environments;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CreatedBy = createdBy;
            this.LastUsedAt = lastUsedAt;
            this.VersionLogsCount = versionLogsCount;
            this.TotalLogsCount = totalLogsCount;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Evaluators = evaluators;
            this.EvaluatorAggregates = evaluatorAggregates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptResponse" /> class.
        /// </summary>
        public PromptResponse()
        {
        }
    }
}