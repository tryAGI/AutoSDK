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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ObservationV2> Data { get; set; } = default!;

        /// <summary>
        /// Metadata for cursor-based pagination
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ObservationsV2Meta Meta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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