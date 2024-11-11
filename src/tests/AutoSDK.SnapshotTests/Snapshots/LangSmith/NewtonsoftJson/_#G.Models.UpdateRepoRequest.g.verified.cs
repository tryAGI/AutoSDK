//HintName: G.Models.UpdateRepoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fields to update a repo
    /// </summary>
    public sealed partial class UpdateRepoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_archived")]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRepoRequest" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="readme"></param>
        /// <param name="tags"></param>
        /// <param name="isPublic"></param>
        /// <param name="isArchived"></param>
        public UpdateRepoRequest(
            string? description,
            string? readme,
            global::System.Collections.Generic.IList<string>? tags,
            bool? isPublic,
            bool? isArchived)
        {
            this.Description = description;
            this.Readme = readme;
            this.Tags = tags;
            this.IsPublic = isPublic;
            this.IsArchived = isArchived;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRepoRequest" /> class.
        /// </summary>
        public UpdateRepoRequest()
        {
        }
    }
}