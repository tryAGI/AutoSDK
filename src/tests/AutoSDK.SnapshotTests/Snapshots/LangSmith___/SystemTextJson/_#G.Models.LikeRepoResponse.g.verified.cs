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
        [global::System.Text.Json.Serialization.JsonPropertyName("likes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Likes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LikeRepoResponse" /> class.
        /// </summary>
        /// <param name="likes"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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