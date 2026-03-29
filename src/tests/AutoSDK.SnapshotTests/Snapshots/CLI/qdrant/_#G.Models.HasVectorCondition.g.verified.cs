//HintName: G.Models.HasVectorCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter points which have specific vector assigned
    /// </summary>
    public sealed partial class HasVectorCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_vector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HasVector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HasVectorCondition" /> class.
        /// </summary>
        /// <param name="hasVector"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HasVectorCondition(
            string hasVector)
        {
            this.HasVector = hasVector ?? throw new global::System.ArgumentNullException(nameof(hasVector));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HasVectorCondition" /> class.
        /// </summary>
        public HasVectorCondition()
        {
        }
    }
}