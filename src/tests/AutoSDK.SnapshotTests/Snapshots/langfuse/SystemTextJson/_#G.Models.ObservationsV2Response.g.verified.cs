//HintName: G.Models.ObservationsV2Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing observations with field-group-based filtering and cursor-based pagination.<br/>
    /// The `data` array contains observation objects with only the requested field groups included.<br/>
    /// Use the `cursor` in `meta` to retrieve the next page of results.
    /// </summary>
    public sealed partial class ObservationsV2Response
    {
        /// <summary>
        /// Array of observation objects. Fields included depend on the `fields` parameter in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ObservationV2> Data { get; set; }

        /// <summary>
        /// Metadata for cursor-based pagination
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ObservationsV2Meta Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationsV2Response" /> class.
        /// </summary>
        /// <param name="data">
        /// Array of observation objects. Fields included depend on the `fields` parameter in the request.
        /// </param>
        /// <param name="meta">
        /// Metadata for cursor-based pagination
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservationsV2Response(
            global::System.Collections.Generic.IList<global::G.ObservationV2> data,
            global::G.ObservationsV2Meta meta)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationsV2Response" /> class.
        /// </summary>
        public ObservationsV2Response()
        {
        }
    }
}