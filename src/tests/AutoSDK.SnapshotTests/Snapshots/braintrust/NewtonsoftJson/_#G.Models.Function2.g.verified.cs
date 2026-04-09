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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The transaction id of an event is unique to the network operation that processed the event insertion. Transaction ids are monotonically increasing over time and can be used to retrieve a versioned snapshot of the prompt (see the `version` parameter)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_xact_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string XactId { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the project that the prompt belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// A literal 'p' which identifies the object as a project prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log_id")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FunctionLogIdJsonConverter))]
        public global::G.FunctionLogId LogId { get; set; }

        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OrgId { get; set; } = default!;

        /// <summary>
        /// Name of the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Textual description of the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Date of prompt creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// The prompt, model, and its parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_data")]
        public global::G.PromptDataNullish? PromptData { get; set; }

        /// <summary>
        /// A list of tags for the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// User-controlled metadata about the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FunctionTypeEnumNullishJsonConverter))]
        public global::G.FunctionTypeEnumNullish? FunctionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FunctionData FunctionData { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("origin")]
        public global::G.FunctionOrigin? Origin { get; set; }

        /// <summary>
        /// JSON schema for the function's parameters and return type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_schema")]
        public global::G.FunctionFunctionSchema? FunctionSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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