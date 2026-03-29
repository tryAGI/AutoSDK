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
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Unique identifier for the Prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the directory that the file is in on Humanloop.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directoryId")]
        public string? DirectoryId { get; set; }

        /// <summary>
        /// The model instance used, e.g. gpt-4.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The provider model endpoint used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// The template for the prompt as a list of chat messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public global::System.Collections.Generic.IList<global::G.ChatMessage>? Template { get; set; }

        /// <summary>
        /// The company providing the underlying model service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Sampling temperature for generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topP")]
        public double? TopP { get; set; }

        /// <summary>
        /// Stop sequence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public string? Stop { get; set; }

        /// <summary>
        /// Presence penalty value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presencePenalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// Frequency penalty value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequencyPenalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Other parameter values to be passed to the provider call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other")]
        public object? Other { get; set; }

        /// <summary>
        /// Seed for deterministic sampling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseFormat")]
        public global::G.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.ToolFunction>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedTools")]
        public global::System.Collections.Generic.IList<global::G.LinkedToolResponse>? LinkedTools { get; set; }

        /// <summary>
        /// Additional fields to describe the Prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Unique name for the Prompt version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionName")]
        public string? VersionName { get; set; }

        /// <summary>
        /// Description of the version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionDescription")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// Description of the Prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Long description of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// Name of the Prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Unique identifier for the specific Prompt Version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptResponseTypeJsonConverter))]
        public global::G.PromptResponseType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<global::G.EnvironmentResponse>? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public global::G.UserResponse? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUsedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUsedAt { get; set; }

        /// <summary>
        /// The number of logs generated for this Prompt Version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionLogsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionLogsCount { get; set; }

        /// <summary>
        /// The number of logs generated across all Prompt Versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalLogsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalLogsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.InputResponse> Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        public global::System.Collections.Generic.IList<global::G.MonitoringEvaluatorResponse>? Evaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorAggregates")]
        public global::System.Collections.Generic.IList<global::G.EvaluatorAggregate>? EvaluatorAggregates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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