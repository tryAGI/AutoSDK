//HintName: G.Models.PresentFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PresentFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PresentFilterTypeJsonConverter))]
        public global::G.PresentFilterType Type { get; set; }

        /// <summary>
        /// pr: present (has value), np: not present
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PresentFilterOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PresentFilterOp Op { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentFilter" /> class.
        /// </summary>
        /// <param name="op">
        /// pr: present (has value), np: not present
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PresentFilter(
            global::G.PresentFilterOp op,
            global::G.PresentFilterType type)
        {
            this.Type = type;
            this.Op = op;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PresentFilter" /> class.
        /// </summary>
        public PresentFilter()
        {
        }
    }
}