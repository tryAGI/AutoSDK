//HintName: G.Models.RealtimeResponseCreateParamsTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeResponseCreateParamsTool
    {
        /// <summary>
        /// The type of the tool, i.e. `function`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeResponseCreateParamsToolType? Type { get; set; }

        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the function, including guidance on when and how <br/>
        /// to call it, and guidance about what to tell the user when calling <br/>
        /// (if anything).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Parameters of the function in JSON Schema.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateParamsTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the tool, i.e. `function`.
        /// </param>
        /// <param name="name">
        /// The name of the function.
        /// </param>
        /// <param name="description">
        /// The description of the function, including guidance on when and how <br/>
        /// to call it, and guidance about what to tell the user when calling <br/>
        /// (if anything).
        /// </param>
        /// <param name="parameters">
        /// Parameters of the function in JSON Schema.
        /// </param>
        public RealtimeResponseCreateParamsTool(
            global::G.RealtimeResponseCreateParamsToolType? type,
            string? name,
            string? description,
            object? parameters)
        {
            this.Type = type;
            this.Name = name;
            this.Description = description;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreateParamsTool" /> class.
        /// </summary>
        public RealtimeResponseCreateParamsTool()
        {
        }
    }
}