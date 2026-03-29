//HintName: G.Models.UserMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceType", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResourceType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public string? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastModified")]
        public string? LastModified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMeta" /> class.
        /// </summary>
        /// <param name="resourceType"></param>
        /// <param name="created"></param>
        /// <param name="lastModified"></param>
        public UserMeta(
            string resourceType,
            string? created,
            string? lastModified)
        {
            this.ResourceType = resourceType ?? throw new global::System.ArgumentNullException(nameof(resourceType));
            this.Created = created;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMeta" /> class.
        /// </summary>
        public UserMeta()
        {
        }
    }
}