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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Points { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FollowedTag" /> class.
        /// </summary>
        /// <param name="id">
        /// Tag id
        /// </param>
        /// <param name="name"></param>
        /// <param name="points"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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