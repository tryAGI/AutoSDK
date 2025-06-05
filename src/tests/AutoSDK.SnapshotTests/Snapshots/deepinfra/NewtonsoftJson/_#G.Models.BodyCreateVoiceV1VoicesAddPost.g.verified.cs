//HintName: G.Models.BodyCreateVoiceV1VoicesAddPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateVoiceV1VoicesAddPost
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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<byte[]> Files { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateVoiceV1VoicesAddPost" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="files"></param>
        public BodyCreateVoiceV1VoicesAddPost(
            string name,
            string description,
            global::System.Collections.Generic.IList<byte[]> files)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateVoiceV1VoicesAddPost" /> class.
        /// </summary>
        public BodyCreateVoiceV1VoicesAddPost()
        {
        }
    }
}