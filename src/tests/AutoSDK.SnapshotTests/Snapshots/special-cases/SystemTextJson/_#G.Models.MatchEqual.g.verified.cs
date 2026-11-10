//HintName: G.Models.MatchEqual.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MatchEqual
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Equal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchEqual" /> class.
        /// </summary>
        /// <param name="equal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MatchEqual(
            string equal)
        {
            this.Equal = equal ?? throw new global::System.ArgumentNullException(nameof(equal));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchEqual" /> class.
        /// </summary>
        public MatchEqual()
        {
        }

    }
}