//HintName: G.Models.ToolCallChunkFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallChunkFunction
    {
        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A chunk of the arguments string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallChunkFunction" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function.
        /// </param>
        /// <param name="arguments">
        /// A chunk of the arguments string.
        /// </param>
        public ToolCallChunkFunction(
            string? name,
            string? arguments)
        {
            this.Name = name;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallChunkFunction" /> class.
        /// </summary>
        public ToolCallChunkFunction()
        {
        }
    }
}