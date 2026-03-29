//HintName: G.Models.StringFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StringFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StringFilterTypeJsonConverter))]
        public global::G.StringFilterType Type { get; set; }

        /// <summary>
        /// eq: equal, ne: not equal, sw: starts with, ew: ends with, co: contains
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StringFilterOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StringFilterOp Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StringFilter" /> class.
        /// </summary>
        /// <param name="op">
        /// eq: equal, ne: not equal, sw: starts with, ew: ends with, co: contains
        /// </param>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StringFilter(
            global::G.StringFilterOp op,
            string value,
            global::G.StringFilterType type)
        {
            this.Type = type;
            this.Op = op;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringFilter" /> class.
        /// </summary>
        public StringFilter()
        {
        }
    }
}