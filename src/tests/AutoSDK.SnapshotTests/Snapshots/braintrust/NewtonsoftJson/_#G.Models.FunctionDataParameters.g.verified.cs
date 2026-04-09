//HintName: G.Models.FunctionDataParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionDataParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FunctionDataParametersTypeJsonConverter))]
        public global::G.FunctionDataParametersType Type { get; set; }

        /// <summary>
        /// The parameters data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> Data { get; set; } = default!;

        /// <summary>
        /// JSON Schema format for parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("__schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FunctionDataParametersSchema Schema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataParameters" /> class.
        /// </summary>
        /// <param name="data">
        /// The parameters data
        /// </param>
        /// <param name="schema">
        /// JSON Schema format for parameters
        /// </param>
        /// <param name="type"></param>
        public FunctionDataParameters(
            global::System.Collections.Generic.Dictionary<string, object?> data,
            global::G.FunctionDataParametersSchema schema,
            global::G.FunctionDataParametersType type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataParameters" /> class.
        /// </summary>
        public FunctionDataParameters()
        {
        }
    }
}