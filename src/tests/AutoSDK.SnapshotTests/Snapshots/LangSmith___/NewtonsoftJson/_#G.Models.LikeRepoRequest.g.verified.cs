//HintName: G.Models.LikeRepoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LikeRepoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("like", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Like { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LikeRepoRequest" /> class.
        /// </summary>
        /// <param name="like"></param>
        public LikeRepoRequest(
            bool like)
        {
            this.Like = like;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LikeRepoRequest" /> class.
        /// </summary>
        public LikeRepoRequest()
        {
        }
    }
}