//HintName: G.Models.ChatToolCallFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallFunction
    {
        /// <summary>
        /// Function name to call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Function arguments as JSON string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments", Required = global::Newtonsoft.Json.Required.Always)]
        public string Arguments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallFunction" /> class.
        /// </summary>
        /// <param name="name">
        /// Function name to call
        /// </param>
        /// <param name="arguments">
        /// Function arguments as JSON string
        /// </param>
        public ChatToolCallFunction(
            string name,
            string arguments)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallFunction" /> class.
        /// </summary>
        public ChatToolCallFunction()
        {
        }
    }
}