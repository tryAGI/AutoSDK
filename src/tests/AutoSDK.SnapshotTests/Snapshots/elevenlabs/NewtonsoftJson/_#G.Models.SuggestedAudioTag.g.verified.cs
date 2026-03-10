//HintName: G.Models.SuggestedAudioTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SuggestedAudioTag
    {
        /// <summary>
        /// Audio tag to use (for best performance, 1-2 words, e.g., 'happy', 'excited')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag", Required = global::Newtonsoft.Json.Required.Always)]
        public string Tag { get; set; } = default!;

        /// <summary>
        /// Optional description of when to use this tag
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestedAudioTag" /> class.
        /// </summary>
        /// <param name="tag">
        /// Audio tag to use (for best performance, 1-2 words, e.g., 'happy', 'excited')
        /// </param>
        /// <param name="description">
        /// Optional description of when to use this tag
        /// </param>
        public SuggestedAudioTag(
            string tag,
            string? description)
        {
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestedAudioTag" /> class.
        /// </summary>
        public SuggestedAudioTag()
        {
        }
    }
}