//HintName: G.Models.MatchRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MatchRange
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rangeFrom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RangeFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchRange" /> class.
        /// </summary>
        /// <param name="rangeFrom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MatchRange(
            int rangeFrom)
        {
            this.RangeFrom = rangeFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchRange" /> class.
        /// </summary>
        public MatchRange()
        {
        }

    }
}