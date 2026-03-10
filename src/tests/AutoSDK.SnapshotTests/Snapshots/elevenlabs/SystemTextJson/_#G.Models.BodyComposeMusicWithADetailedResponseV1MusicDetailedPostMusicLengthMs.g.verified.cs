//HintName: G.Models.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostMusicLengthMs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The length of the song to generate in milliseconds. Used only in conjunction with `prompt`. Must be between 3000ms and 600000ms. Optional - if not provided, the model will choose a length based on the prompt.
    /// </summary>
    public sealed partial class BodyComposeMusicWithADetailedResponseV1MusicDetailedPostMusicLengthMs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}