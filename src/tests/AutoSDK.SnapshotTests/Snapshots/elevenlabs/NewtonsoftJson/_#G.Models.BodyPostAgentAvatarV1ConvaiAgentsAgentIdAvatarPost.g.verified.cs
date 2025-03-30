//HintName: G.Models.BodyPostAgentAvatarV1ConvaiAgentsAgentIdAvatarPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyPostAgentAvatarV1ConvaiAgentsAgentIdAvatarPost
    {
        /// <summary>
        /// An image file to be used as the agent's avatar.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] AvatarFile { get; set; } = default!;

        /// <summary>
        /// An image file to be used as the agent's avatar.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarFilename { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPostAgentAvatarV1ConvaiAgentsAgentIdAvatarPost" /> class.
        /// </summary>
        /// <param name="avatarFile">
        /// An image file to be used as the agent's avatar.
        /// </param>
        /// <param name="avatarFilename">
        /// An image file to be used as the agent's avatar.
        /// </param>
        public BodyPostAgentAvatarV1ConvaiAgentsAgentIdAvatarPost(
            byte[] avatarFile,
            string avatarFilename)
        {
            this.AvatarFile = avatarFile ?? throw new global::System.ArgumentNullException(nameof(avatarFile));
            this.AvatarFilename = avatarFilename ?? throw new global::System.ArgumentNullException(nameof(avatarFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPostAgentAvatarV1ConvaiAgentsAgentIdAvatarPost" /> class.
        /// </summary>
        public BodyPostAgentAvatarV1ConvaiAgentsAgentIdAvatarPost()
        {
        }
    }
}