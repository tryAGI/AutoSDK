//HintName: G.Models.NestedCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NestedCondition
    {
        /// <summary>
        /// Select points with payload for a specified nested field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nested")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Nested Nested { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NestedCondition" /> class.
        /// </summary>
        /// <param name="nested">
        /// Select points with payload for a specified nested field
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NestedCondition(
            global::G.Nested nested)
        {
            this.Nested = nested ?? throw new global::System.ArgumentNullException(nameof(nested));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NestedCondition" /> class.
        /// </summary>
        public NestedCondition()
        {
        }
    }
}