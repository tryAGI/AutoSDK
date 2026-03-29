//HintName: G.Models.ChatFunctionToolOneOf0Function.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Function definition for tool calling
    /// </summary>
    public sealed partial class ChatFunctionToolOneOf0Function
    {
        /// <summary>
        /// Function name (a-z, A-Z, 0-9, underscores, dashes, max 64 chars)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Function description for the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Function parameters as JSON Schema object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Enable strict schema adherence
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFunctionToolOneOf0Function" /> class.
        /// </summary>
        /// <param name="name">
        /// Function name (a-z, A-Z, 0-9, underscores, dashes, max 64 chars)
        /// </param>
        /// <param name="description">
        /// Function description for the model
        /// </param>
        /// <param name="parameters">
        /// Function parameters as JSON Schema object
        /// </param>
        /// <param name="strict">
        /// Enable strict schema adherence
        /// </param>
        public ChatFunctionToolOneOf0Function(
            string name,
            string? description,
            object? parameters,
            bool? strict)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFunctionToolOneOf0Function" /> class.
        /// </summary>
        public ChatFunctionToolOneOf0Function()
        {
        }
    }
}