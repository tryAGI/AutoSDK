//HintName: G.Models.OnlineScoreConfigScorerVariant2Global.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OnlineScoreConfigScorerVariant2Global
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OnlineScoreConfigScorerVariant2GlobalTypeJsonConverter))]
        public global::G.OnlineScoreConfigScorerVariant2GlobalType Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineScoreConfigScorerVariant2Global" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="functionType">
        /// The type of global function. Defaults to 'scorer'.<br/>
        /// Default Value: scorer
        /// </param>
        public OnlineScoreConfigScorerVariant2Global(
            string name,
            global::G.OnlineScoreConfigScorerVariant2GlobalType type,
            global::G.FunctionTypeEnum? functionType)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FunctionType = functionType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineScoreConfigScorerVariant2Global" /> class.
        /// </summary>
        public OnlineScoreConfigScorerVariant2Global()
        {
        }
    }
}