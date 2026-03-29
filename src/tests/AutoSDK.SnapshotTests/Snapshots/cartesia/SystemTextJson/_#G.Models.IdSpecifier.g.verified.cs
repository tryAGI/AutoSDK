//HintName: G.Models.IdSpecifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IdSpecifier
    {
        /// <summary>
        /// The ID of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The weight of the voice or embedding in the mix. If weights do not sum to 1, they will be normalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdSpecifier" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the voice.
        /// </param>
        /// <param name="weight">
        /// The weight of the voice or embedding in the mix. If weights do not sum to 1, they will be normalized.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdSpecifier(
            string id,
            double weight)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdSpecifier" /> class.
        /// </summary>
        public IdSpecifier()
        {
        }
    }
}