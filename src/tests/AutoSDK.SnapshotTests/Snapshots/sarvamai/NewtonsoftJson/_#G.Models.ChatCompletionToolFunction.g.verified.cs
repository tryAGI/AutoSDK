//HintName: G.Models.ChatCompletionToolFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionToolFunction
    {
        /// <summary>
        /// The name of the function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A description of what the function does
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// JSON Schema describing the function parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToolFunction" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function
        /// </param>
        /// <param name="description">
        /// A description of what the function does
        /// </param>
        /// <param name="parameters">
        /// JSON Schema describing the function parameters
        /// </param>
        public ChatCompletionToolFunction(
            string name,
            string? description,
            object? parameters)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToolFunction" /> class.
        /// </summary>
        public ChatCompletionToolFunction()
        {
        }
    }
}