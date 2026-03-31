//HintName: G.Models.CreateFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFunction
    {
        /// <summary>
        /// Unique identifier for the project that the prompt belongs under
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

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
        public global::G.CreateFunctionOrigin? Origin { get; set; }

        /// <summary>
        /// JSON schema for the function's parameters and return type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_schema")]
        public global::G.CreateFunctionFunctionSchema? FunctionSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFunction" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the prompt belongs under
        /// </param>
        /// <param name="name">
        /// Name of the prompt
        /// </param>
        /// <param name="slug">
        /// Unique identifier for the prompt
        /// </param>
        /// <param name="functionData"></param>
        /// <param name="description">
        /// Textual description of the prompt
        /// </param>
        /// <param name="promptData">
        /// The prompt, model, and its parameters
        /// </param>
        /// <param name="tags">
        /// A list of tags for the prompt
        /// </param>
        /// <param name="functionType"></param>
        /// <param name="origin"></param>
        /// <param name="functionSchema">
        /// JSON schema for the function's parameters and return type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFunction(
            global::System.Guid projectId,
            string name,
            string slug,
            global::G.FunctionData functionData,
            string? description,
            global::G.PromptDataNullish? promptData,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.FunctionTypeEnumNullish? functionType,
            global::G.CreateFunctionOrigin? origin,
            global::G.CreateFunctionFunctionSchema? functionSchema)
        {
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Description = description;
            this.PromptData = promptData;
            this.Tags = tags;
            this.FunctionType = functionType;
            this.FunctionData = functionData;
            this.Origin = origin;
            this.FunctionSchema = functionSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFunction" /> class.
        /// </summary>
        public CreateFunction()
        {
        }
    }
}