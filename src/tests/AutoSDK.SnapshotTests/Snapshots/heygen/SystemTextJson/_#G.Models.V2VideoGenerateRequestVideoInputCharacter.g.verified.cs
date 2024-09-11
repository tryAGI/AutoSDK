//HintName: G.Models.V2VideoGenerateRequestVideoInputCharacter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2VideoGenerateRequestVideoInputCharacter
    {
        /// <summary>
        /// Example: Kristin_public_3_20240108
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_id")]
        public string? AvatarId { get; set; }

        /// <summary>
        /// Example: normal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_style")]
        public string? AvatarStyle { get; set; }

        /// <summary>
        /// Example: avatar
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}