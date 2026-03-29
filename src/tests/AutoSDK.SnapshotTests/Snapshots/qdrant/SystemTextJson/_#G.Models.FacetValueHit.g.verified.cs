//HintName: G.Models.FacetValueHit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FacetValueHit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FacetValueJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FacetValue Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetValueHit" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FacetValueHit(
            global::G.FacetValue value,
            int count)
        {
            this.Value = value;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetValueHit" /> class.
        /// </summary>
        public FacetValueHit()
        {
        }
    }
}