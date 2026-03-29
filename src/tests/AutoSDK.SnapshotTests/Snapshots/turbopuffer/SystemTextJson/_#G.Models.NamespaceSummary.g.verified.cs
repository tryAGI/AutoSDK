//HintName: G.Models.NamespaceSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A summary of a namespace.
    /// </summary>
    public sealed partial class NamespaceSummary
    {
        /// <summary>
        /// The namespace ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// The namespace ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamespaceSummary(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceSummary" /> class.
        /// </summary>
        public NamespaceSummary()
        {
        }
    }
}