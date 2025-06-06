﻿//HintName: G.Models.ToolCallV2Function.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallV2Function" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="arguments"></param>
        public ToolCallV2Function(
            string? name,
            string? arguments)
        {
            this.Name = name;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallV2Function" /> class.
        /// </summary>
        public ToolCallV2Function()
        {
        }
    }
}