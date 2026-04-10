//HintName: G.Models.ResponsesRequestToolsItems0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Function tool definition
    /// </summary>
    public sealed partial class ResponsesRequestToolsItems0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FunctionToolTypeJsonConverter))]
        public global::G.FunctionToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestToolsItems0" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="strict"></param>
        /// <param name="parameters"></param>
        public ResponsesRequestToolsItems0(
            string name,
            global::G.FunctionToolType type,
            string? description,
            bool? strict,
            object? parameters)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Strict = strict;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestToolsItems0" /> class.
        /// </summary>
        public ResponsesRequestToolsItems0()
        {
        }
    }
}