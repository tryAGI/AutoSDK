//HintName: G.Models.MatchValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Exact match of the given value
    /// </summary>
    public sealed partial class MatchValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ValueVariantsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ValueVariants Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchValue" /> class.
        /// </summary>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MatchValue(
            global::G.ValueVariants value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchValue" /> class.
        /// </summary>
        public MatchValue()
        {
        }
    }
}