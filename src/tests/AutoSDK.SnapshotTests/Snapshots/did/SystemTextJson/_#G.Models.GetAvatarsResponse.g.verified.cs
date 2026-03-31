//HintName: G.Models.GetAvatarsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAvatarsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetAvatarsResponseAvatar> Avatars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarsResponse" /> class.
        /// </summary>
        /// <param name="avatars"></param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvatarsResponse(
            global::System.Collections.Generic.IList<global::G.GetAvatarsResponseAvatar> avatars,
            string? token)
        {
            this.Avatars = avatars ?? throw new global::System.ArgumentNullException(nameof(avatars));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvatarsResponse" /> class.
        /// </summary>
        public GetAvatarsResponse()
        {
        }
    }
}