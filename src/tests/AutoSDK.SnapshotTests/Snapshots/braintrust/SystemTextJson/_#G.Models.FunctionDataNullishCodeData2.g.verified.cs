//HintName: G.Models.FunctionDataNullishCodeData2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionDataNullishCodeData2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FunctionDataNullishCodeDataType2JsonConverter))]
        public global::G.FunctionDataNullishCodeDataType2 Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime_context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FunctionDataNullishCodeDataRuntimeContext RuntimeContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// SHA256 hash of the code, computed at save time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_hash")]
        public string? CodeHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishCodeData2" /> class.
        /// </summary>
        /// <param name="runtimeContext"></param>
        /// <param name="code"></param>
        /// <param name="type"></param>
        /// <param name="codeHash">
        /// SHA256 hash of the code, computed at save time
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDataNullishCodeData2(
            global::G.FunctionDataNullishCodeDataRuntimeContext runtimeContext,
            string code,
            global::G.FunctionDataNullishCodeDataType2 type,
            string? codeHash)
        {
            this.Type = type;
            this.RuntimeContext = runtimeContext ?? throw new global::System.ArgumentNullException(nameof(runtimeContext));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.CodeHash = codeHash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishCodeData2" /> class.
        /// </summary>
        public FunctionDataNullishCodeData2()
        {
        }
    }
}