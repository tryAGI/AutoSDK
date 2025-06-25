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
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] AvatarFile { get; set; }

        /// <summary>
        /// An image file to be used as the agent's avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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