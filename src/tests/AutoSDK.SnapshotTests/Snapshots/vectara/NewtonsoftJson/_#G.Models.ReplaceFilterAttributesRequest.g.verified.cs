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
        [global::Newtonsoft.Json.JsonProperty("filter_attributes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FilterAttribute> FilterAttributes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceFilterAttributesRequest" /> class.
        /// </summary>
        /// <param name="filterAttributes">
        /// The new filter attributes.
        /// </param>
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