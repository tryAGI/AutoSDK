//HintName: G.Models.FunctionDataNullishGlobal.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionDataNullishGlobal
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FunctionDataNullishGlobalTypeJsonConverter))]
        public global::G.FunctionDataNullishGlobalType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The type of global function. Defaults to 'scorer'.<br/>
        /// Default Value: scorer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FunctionTypeEnumJsonConverter))]
        public global::G.FunctionTypeEnum? FunctionType { get; set; }

        /// <summary>
        /// Configuration options to pass to the global function (e.g., for preprocessor customization)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishGlobal" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="functionType">
        /// The type of global function. Defaults to 'scorer'.<br/>
        /// Default Value: scorer
        /// </param>
        /// <param name="config">
        /// Configuration options to pass to the global function (e.g., for preprocessor customization)
        /// </param>
        public FunctionDataNullishGlobal(
            string name,
            global::G.FunctionDataNullishGlobalType type,
            global::G.FunctionTypeEnum? functionType,
            global::System.Collections.Generic.Dictionary<string, object?>? config)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FunctionType = functionType;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishGlobal" /> class.
        /// </summary>
        public FunctionDataNullishGlobal()
        {
        }
    }
}