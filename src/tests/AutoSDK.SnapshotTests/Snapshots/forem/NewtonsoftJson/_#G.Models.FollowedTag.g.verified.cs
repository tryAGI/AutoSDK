//HintName: G.Models.FollowedTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of a followed tag
    /// </summary>
    public sealed partial class FollowedTag
    {
        /// <summary>
        /// Tag id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("points", Required = global::Newtonsoft.Json.Required.Always)]
        public float Points { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowedTag" /> class.
        /// </summary>
        /// <param name="id">
        /// Tag id
        /// </param>
        /// <param name="name"></param>
        /// <param name="points"></param>
        public FollowedTag(
            long id,
            string name,
            float points)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Points = points;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowedTag" /> class.
        /// </summary>
        public FollowedTag()
        {
        }
    }
}