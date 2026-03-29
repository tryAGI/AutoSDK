//HintName: G.Models.TabValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TabValue
    {
        /// <summary>
        /// 本地默认值
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("local_input")]
        public string? LocalInput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param_source")]
        public int? ParamSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public int? Type { get; set; }

        /// <summary>
        /// 引用variable的key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variable_ref")]
        public string? VariableRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TabValue" /> class.
        /// </summary>
        /// <param name="localInput">
        /// 本地默认值
        /// </param>
        /// <param name="paramSource"></param>
        /// <param name="type"></param>
        /// <param name="variableRef">
        /// 引用variable的key
        /// </param>
        public TabValue(
            string? localInput,
            int? paramSource,
            int? type,
            string? variableRef)
        {
            this.LocalInput = localInput;
            this.ParamSource = paramSource;
            this.Type = type;
            this.VariableRef = variableRef;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TabValue" /> class.
        /// </summary>
        public TabValue()
        {
        }
    }
}