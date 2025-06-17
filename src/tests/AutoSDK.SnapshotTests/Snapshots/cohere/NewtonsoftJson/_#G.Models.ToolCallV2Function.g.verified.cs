//HintName: G.Models.ToolCallV2Function.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallV2Function
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallV2Function" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="name"></param>
        public ToolCallV2Function(
            string? arguments,
            string? name)
        {
            this.Arguments = arguments;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallV2Function" /> class.
        /// </summary>
        public ToolCallV2Function()
        {
        }
    }
}