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
        [global::System.Text.Json.Serialization.JsonPropertyName("like")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Like { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LikeRepoRequest" /> class.
        /// </summary>
        /// <param name="like"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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