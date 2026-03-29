//HintName: G.Models.PartialTextOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialTextOperators
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not-equals")]
        public string? NotEquals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equals")]
        public string? EqualsValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("like")]
        public string? Like { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ilike")]
        public string? Ilike { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contains")]
        public string? Contains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not-contains")]
        public string? NotContains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTextOperators" /> class.
        /// </summary>
        /// <param name="notEquals"></param>
        /// <param name="equalsValue"></param>
        /// <param name="like"></param>
        /// <param name="ilike"></param>
        /// <param name="contains"></param>
        /// <param name="notContains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialTextOperators(
            string? notEquals,
            string? equalsValue,
            string? like,
            string? ilike,
            string? contains,
            string? notContains)
        {
            this.NotEquals = notEquals;
            this.EqualsValue = equalsValue;
            this.Like = like;
            this.Ilike = ilike;
            this.Contains = contains;
            this.NotContains = notContains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTextOperators" /> class.
        /// </summary>
        public PartialTextOperators()
        {
        }
    }
}