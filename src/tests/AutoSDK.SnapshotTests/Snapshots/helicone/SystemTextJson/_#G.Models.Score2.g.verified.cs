//HintName: G.Models.Score2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Score2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ValueType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<double?, global::System.DateTime?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<double?, global::System.DateTime?, string> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Score2" /> class.
        /// </summary>
        /// <param name="valueType"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Score2(
            string valueType,
            global::G.AnyOf<double?, global::System.DateTime?, string> value)
        {
            this.ValueType = valueType ?? throw new global::System.ArgumentNullException(nameof(valueType));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Score2" /> class.
        /// </summary>
        public Score2()
        {
        }
    }
}