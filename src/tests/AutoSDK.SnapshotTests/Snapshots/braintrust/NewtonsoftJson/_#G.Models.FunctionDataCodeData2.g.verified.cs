//HintName: G.Models.FunctionDataCodeData2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionDataCodeData2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FunctionDataCodeDataType2JsonConverter))]
        public global::G.FunctionDataCodeDataType2 Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runtime_context", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FunctionDataCodeDataRuntimeContext RuntimeContext { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// SHA256 hash of the code, computed at save time
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_hash")]
        public string? CodeHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataCodeData2" /> class.
        /// </summary>
        /// <param name="runtimeContext"></param>
        /// <param name="code"></param>
        /// <param name="type"></param>
        /// <param name="codeHash">
        /// SHA256 hash of the code, computed at save time
        /// </param>
        public FunctionDataCodeData2(
            global::G.FunctionDataCodeDataRuntimeContext runtimeContext,
            string code,
            global::G.FunctionDataCodeDataType2 type,
            string? codeHash)
        {
            this.Type = type;
            this.RuntimeContext = runtimeContext ?? throw new global::System.ArgumentNullException(nameof(runtimeContext));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.CodeHash = codeHash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataCodeData2" /> class.
        /// </summary>
        public FunctionDataCodeData2()
        {
        }
    }
}