//HintName: G.Models.MatchAny.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Exact match on any of the given values
    /// </summary>
    public sealed partial class MatchAny
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("any")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyVariantsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyVariants Any { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchAny" /> class.
        /// </summary>
        /// <param name="any"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MatchAny(
            global::G.AnyVariants any)
        {
            this.Any = any;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchAny" /> class.
        /// </summary>
        public MatchAny()
        {
        }
    }
}