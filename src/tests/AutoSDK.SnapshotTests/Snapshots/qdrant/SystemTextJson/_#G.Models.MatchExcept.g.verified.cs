//HintName: G.Models.MatchExcept.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Should have at least one value not matching the any given values
    /// </summary>
    public sealed partial class MatchExcept
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("except")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyVariantsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyVariants Except { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchExcept" /> class.
        /// </summary>
        /// <param name="except"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MatchExcept(
            global::G.AnyVariants except)
        {
            this.Except = except;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchExcept" /> class.
        /// </summary>
        public MatchExcept()
        {
        }
    }
}