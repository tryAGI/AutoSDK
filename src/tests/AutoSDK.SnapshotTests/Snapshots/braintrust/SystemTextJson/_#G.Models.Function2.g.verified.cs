//HintName: G.Models.Function2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Function2
    {
        /// <summary>
        /// Unique identifier for the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The transaction id of an event is unique to the network operation that processed the event insertion. Transaction ids are monotonically increasing over time and can be used to retrieve a versioned snapshot of the prompt (see the `version` parameter)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_xact_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string XactId { get; set; }

        /// <summary>
        /// Unique identifier for the project that the prompt belongs under
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// A literal 'p' which identifies the object as a project prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FunctionLogIdJsonConverter))]
        public global::G.FunctionLogId LogId { get; set; }

        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrgId { get; set; }

        /// <summary>
        /// Name of the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Unique identifier for the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Textual description of the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Date of prompt creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// The prompt, model, and its parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_data")]
        public global::G.PromptDataNullish? PromptData { get; set; }

        /// <summary>
        /// A list of tags for the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// User-controlled metadata about the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FunctionTypeEnumNullishJsonConverter))]
        public global::G.FunctionTypeEnumNullish? FunctionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FunctionDataJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FunctionData FunctionData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        public global::G.FunctionOrigin? Origin { get; set; }

        /// <summary>
        /// JSON schema for the function's parameters and return type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_schema")]
        public global::G.FunctionFunctionSchema? FunctionSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Function2" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the prompt
        /// </param>
        /// <param name="xactId">
        /// The transaction id of an event is unique to the network operation that processed the event insertion. Transaction ids are monotonically increasing over time and can be used to retrieve a versioned snapshot of the prompt (see the `version` parameter)
        /// </param>
        /// <param name="projectId">
        /// Unique identifier for the project that the prompt belongs under
        /// </param>
        /// <param name="orgId">
        /// Unique identifier for the organization
        /// </param>
        /// <param name="name">
        /// Name of the prompt
        /// </param>
        /// <param name="slug">
        /// Unique identifier for the prompt
        /// </param>
        /// <param name="functionData"></param>
        /// <param name="logId">
        /// A literal 'p' which identifies the object as a project prompt
        /// </param>
        /// <param name="description">
        /// Textual description of the prompt
        /// </param>
        /// <param name="created">
        /// Date of prompt creation
        /// </param>
        /// <param name="promptData">
        /// The prompt, model, and its parameters
        /// </param>
        /// <param name="tags">
        /// A list of tags for the prompt
        /// </param>
        /// <param name="metadata">
        /// User-controlled metadata about the prompt
        /// </param>
        /// <param name="functionType"></param>
        /// <param name="origin"></param>
        /// <param name="functionSchema">
        /// JSON schema for the function's parameters and return type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Function2(
            global::System.Guid id,
            string xactId,
            global::System.Guid projectId,
            global::System.Guid orgId,
            string name,
            string slug,
            global::G.FunctionData functionData,
            global::G.FunctionLogId logId,
            string? description,
            global::System.DateTime? created,
            global::G.PromptDataNullish? promptData,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata,
            global::G.FunctionTypeEnumNullish? functionType,
            global::G.FunctionOrigin? origin,
            global::G.FunctionFunctionSchema? functionSchema)
        {
            this.Id = id;
            this.XactId = xactId ?? throw new global::System.ArgumentNullException(nameof(xactId));
            this.ProjectId = projectId;
            this.LogId = logId;
            this.OrgId = orgId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Description = description;
            this.Created = created;
            this.PromptData = promptData;
            this.Tags = tags;
            this.Metadata = metadata;
            this.FunctionType = functionType;
            this.FunctionData = functionData;
            this.Origin = origin;
            this.FunctionSchema = functionSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Function2" /> class.
        /// </summary>
        public Function2()
        {
        }
    }
}