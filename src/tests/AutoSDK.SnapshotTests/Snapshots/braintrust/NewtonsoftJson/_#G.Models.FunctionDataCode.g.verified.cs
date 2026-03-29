//HintName: G.Models.FunctionDataCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionDataCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FunctionDataCodeType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.AllOf<global::G.FunctionDataCodeData, global::G.CodeBundle>?, global::G.FunctionDataCodeData2> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataCode" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        public FunctionDataCode(
            global::G.AnyOf<global::G.AllOf<global::G.FunctionDataCodeData, global::G.CodeBundle>?, global::G.FunctionDataCodeData2> data,
            global::G.FunctionDataCodeType type)
        {
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataCode" /> class.
        /// </summary>
        public FunctionDataCode()
        {
        }
    }
}