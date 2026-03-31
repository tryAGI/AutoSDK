//HintName: G.Models.FunctionDataNullishCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionDataNullishCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FunctionDataNullishCodeTypeJsonConverter))]
        public global::G.FunctionDataNullishCodeType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.AllOf<global::G.FunctionDataNullishCodeData, global::G.CodeBundle>?, global::G.FunctionDataNullishCodeData2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.AllOf<global::G.FunctionDataNullishCodeData, global::G.CodeBundle>?, global::G.FunctionDataNullishCodeData2> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishCode" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDataNullishCode(
            global::G.AnyOf<global::G.AllOf<global::G.FunctionDataNullishCodeData, global::G.CodeBundle>?, global::G.FunctionDataNullishCodeData2> data,
            global::G.FunctionDataNullishCodeType type)
        {
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDataNullishCode" /> class.
        /// </summary>
        public FunctionDataNullishCode()
        {
        }
    }
}