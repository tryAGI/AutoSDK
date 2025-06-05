//HintName: G.Models.BodyUpdateVoiceV1VoicesVoiceIdEditPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateVoiceV1VoicesVoiceIdEditPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateVoiceV1VoicesVoiceIdEditPost" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public BodyUpdateVoiceV1VoicesVoiceIdEditPost(
            string name,
            string description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateVoiceV1VoicesVoiceIdEditPost" /> class.
        /// </summary>
        public BodyUpdateVoiceV1VoicesVoiceIdEditPost()
        {
        }
    }
}