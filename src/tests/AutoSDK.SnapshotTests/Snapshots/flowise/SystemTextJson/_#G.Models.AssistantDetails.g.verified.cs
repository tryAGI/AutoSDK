//HintName: G.Models.AssistantDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantDetails
    {
        /// <summary>
        /// Example: asst_zbNeYIuXIUSKVHjJkfRo6ilv
        /// </summary>
        /// <example>asst_zbNeYIuXIUSKVHjJkfRo6ilv</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: assistant
        /// </summary>
        /// <example>assistant</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: gpt-4
        /// </summary>
        /// <example>gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Example: You are a helpful assistant, do your best to answer question and query
        /// </summary>
        /// <example>You are a helpful assistant, do your best to answer question and query</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Example: [function, code_interpreter, file_search]
        /// </summary>
        /// <example>[function, code_interpreter, file_search]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<string>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_resources")]
        public global::System.Collections.Generic.Dictionary<string, object>? ToolResources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantDetails" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: asst_zbNeYIuXIUSKVHjJkfRo6ilv
        /// </param>
        /// <param name="name">
        /// Example: assistant
        /// </param>
        /// <param name="description"></param>
        /// <param name="model">
        /// Example: gpt-4
        /// </param>
        /// <param name="instructions">
        /// Example: You are a helpful assistant, do your best to answer question and query
        /// </param>
        /// <param name="temperature">
        /// Example: 1
        /// </param>
        /// <param name="topP">
        /// Example: 1
        /// </param>
        /// <param name="tools">
        /// Example: [function, code_interpreter, file_search]
        /// </param>
        /// <param name="toolResources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantDetails(
            string? id,
            string? name,
            string? description,
            string? model,
            string? instructions,
            double? temperature,
            double? topP,
            global::System.Collections.Generic.IList<string>? tools,
            global::System.Collections.Generic.Dictionary<string, object>? toolResources)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Model = model;
            this.Instructions = instructions;
            this.Temperature = temperature;
            this.TopP = topP;
            this.Tools = tools;
            this.ToolResources = toolResources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantDetails" /> class.
        /// </summary>
        public AssistantDetails()
        {
        }
    }
}