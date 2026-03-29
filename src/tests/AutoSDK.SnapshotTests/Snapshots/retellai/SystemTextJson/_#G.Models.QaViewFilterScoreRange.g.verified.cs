//HintName: G.Models.QaViewFilterScoreRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated: use 'score' instead.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class QaViewFilterScoreRange
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.QaViewFilterScoreRangeTypeJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.QaViewFilterScoreRangeType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required double Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.QaViewFilterScoreRangeOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::G.QaViewFilterScoreRangeOp Op { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QaViewFilterScoreRange" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="op"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QaViewFilterScoreRange(
            double value,
            global::G.QaViewFilterScoreRangeOp op,
            global::G.QaViewFilterScoreRangeType? type)
        {
            this.Type = type;
            this.Value = value;
            this.Op = op;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QaViewFilterScoreRange" /> class.
        /// </summary>
        public QaViewFilterScoreRange()
        {
        }
    }
}