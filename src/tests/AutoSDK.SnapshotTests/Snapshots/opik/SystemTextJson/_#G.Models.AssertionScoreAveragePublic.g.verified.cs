//HintName: G.Models.AssertionScoreAveragePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Per-assertion average pass rates for evaluation suite experiments. Null for regular experiments.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class AssertionScoreAveragePublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssertionScoreAveragePublic" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssertionScoreAveragePublic(
            string name,
            double value)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssertionScoreAveragePublic" /> class.
        /// </summary>
        public AssertionScoreAveragePublic()
        {
        }
    }
}