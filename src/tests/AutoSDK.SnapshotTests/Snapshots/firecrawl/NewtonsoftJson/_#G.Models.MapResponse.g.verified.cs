//HintName: G.Models.MapResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MapResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("links")]
        public global::System.Collections.Generic.IList<string>? Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MapResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="links"></param>
        public MapResponse(
            bool? success,
            global::System.Collections.Generic.IList<string>? links)
        {
            this.Success = success;
            this.Links = links;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapResponse" /> class.
        /// </summary>
        public MapResponse()
        {
        }
    }
}