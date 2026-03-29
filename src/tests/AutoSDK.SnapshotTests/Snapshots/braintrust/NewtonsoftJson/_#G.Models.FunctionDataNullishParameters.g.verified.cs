//HintName: G.Models.FunctionDataNullishParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionDataNullishParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FunctionDataNullishParametersType Type { get; set; }

        /// <summary>
        /// The parameters data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> Data { get; set; } = default!;

        /// <summary>
        /// JSON Schema format for parameters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("__schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FunctionDataNullishParametersSchema Schema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishParameters" /> class.
        /// </summary>
        /// <param name="data">
        /// The parameters data
        /// </param>
        /// <param name="schema">
        /// JSON Schema format for parameters
        /// </param>
        /// <param name="type"></param>
        public FunctionDataNullishParameters(
            global::System.Collections.Generic.Dictionary<string, object?> data,
            global::G.FunctionDataNullishParametersSchema schema,
            global::G.FunctionDataNullishParametersType type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishParameters" /> class.
        /// </summary>
        public FunctionDataNullishParameters()
        {
        }
    }
}