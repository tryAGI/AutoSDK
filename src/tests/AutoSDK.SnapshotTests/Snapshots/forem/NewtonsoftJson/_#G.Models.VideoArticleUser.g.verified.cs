//HintName: G.Models.VideoArticleUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Author of the article
    /// </summary>
    public sealed partial class VideoArticleUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoArticleUser" /> class.
        /// </summary>
        /// <param name="name"></param>
        public VideoArticleUser(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoArticleUser" /> class.
        /// </summary>
        public VideoArticleUser()
        {
        }
    }
}