//HintName: G.Models.GetAnimationsResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnimationsResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("animations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetAnimationsResponseDtoAnimation> Animations { get; set; }

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
        /// Initializes a new instance of the <see cref="GetAnimationsResponseDto" /> class.
        /// </summary>
        /// <param name="animations"></param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnimationsResponseDto(
            global::System.Collections.Generic.IList<global::G.GetAnimationsResponseDtoAnimation> animations,
            string? token)
        {
            this.Animations = animations ?? throw new global::System.ArgumentNullException(nameof(animations));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationsResponseDto" /> class.
        /// </summary>
        public GetAnimationsResponseDto()
        {
        }
    }
}