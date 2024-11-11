//HintName: G.Models.LikeRepoResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LikeRepoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("likes", Required = global::Newtonsoft.Json.Required.Always)]
        public int Likes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LikeRepoResponse" /> class.
        /// </summary>
        /// <param name="likes"></param>
        public LikeRepoResponse(
            int likes)
        {
            this.Likes = likes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LikeRepoResponse" /> class.
        /// </summary>
        public LikeRepoResponse()
        {
        }
    }
}