//HintName: G.Models.ToolParameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolParameter
    {
        /// <summary>
        /// This is the key of the parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The value of the parameter. Any JSON type. String values support Liquid templates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, byte[]>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<string, double?, bool?, object, byte[]> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolParameter" /> class.
        /// </summary>
        /// <param name="key">
        /// This is the key of the parameter.
        /// </param>
        /// <param name="value">
        /// The value of the parameter. Any JSON type. String values support Liquid templates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolParameter(
            string key,
            global::G.OneOf<string, double?, bool?, object, byte[]> value)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolParameter" /> class.
        /// </summary>
        public ToolParameter()
        {
        }
    }
}