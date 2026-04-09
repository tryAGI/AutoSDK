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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.QaViewFilterScoreRangeTypeJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.QaViewFilterScoreRangeType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.QaViewFilterScoreRangeOpJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.QaViewFilterScoreRangeOp Op { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QaViewFilterScoreRange" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="op"></param>
        /// <param name="type"></param>
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