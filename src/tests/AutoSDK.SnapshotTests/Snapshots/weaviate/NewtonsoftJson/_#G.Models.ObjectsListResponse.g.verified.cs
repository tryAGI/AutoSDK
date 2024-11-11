//HintName: G.Models.ObjectsListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of Objects.
    /// </summary>
    public sealed partial class ObjectsListResponse
    {
        /// <summary>
        /// The actual list of Objects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objects")]
        public global::System.Collections.Generic.IList<global::G.Object>? Objects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecations")]
        public global::System.Collections.Generic.IList<global::G.Deprecation>? Deprecations { get; set; }

        /// <summary>
        /// The total number of Objects for the query. The number of items in a response may be smaller due to paging.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalResults")]
        public long? TotalResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsListResponse" /> class.
        /// </summary>
        /// <param name="objects">
        /// The actual list of Objects.
        /// </param>
        /// <param name="deprecations"></param>
        /// <param name="totalResults">
        /// The total number of Objects for the query. The number of items in a response may be smaller due to paging.
        /// </param>
        public ObjectsListResponse(
            global::System.Collections.Generic.IList<global::G.Object>? objects,
            global::System.Collections.Generic.IList<global::G.Deprecation>? deprecations,
            long? totalResults)
        {
            this.Objects = objects;
            this.Deprecations = deprecations;
            this.TotalResults = totalResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectsListResponse" /> class.
        /// </summary>
        public ObjectsListResponse()
        {
        }
    }
}