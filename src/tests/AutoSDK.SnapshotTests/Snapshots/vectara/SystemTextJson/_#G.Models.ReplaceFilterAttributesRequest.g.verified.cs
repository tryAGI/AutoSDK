//HintName: G.Models.ReplaceFilterAttributesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to replace all filter attributes for a corpus with a new set of attributes.
    /// </summary>
    public sealed partial class ReplaceFilterAttributesRequest
    {
        /// <summary>
        /// The new filter attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FilterAttribute> FilterAttributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceFilterAttributesRequest" /> class.
        /// </summary>
        /// <param name="filterAttributes">
        /// The new filter attributes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplaceFilterAttributesRequest(
            global::System.Collections.Generic.IList<global::G.FilterAttribute> filterAttributes)
        {
            this.FilterAttributes = filterAttributes ?? throw new global::System.ArgumentNullException(nameof(filterAttributes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceFilterAttributesRequest" /> class.
        /// </summary>
        public ReplaceFilterAttributesRequest()
        {
        }
    }
}