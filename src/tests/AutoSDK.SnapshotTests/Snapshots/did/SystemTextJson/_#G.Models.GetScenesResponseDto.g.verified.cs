//HintName: G.Models.GetScenesResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetScenesResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetScenesResponseDtoScene> Scenes { get; set; }

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
        /// Initializes a new instance of the <see cref="GetScenesResponseDto" /> class.
        /// </summary>
        /// <param name="scenes"></param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetScenesResponseDto(
            global::System.Collections.Generic.IList<global::G.GetScenesResponseDtoScene> scenes,
            string? token)
        {
            this.Scenes = scenes ?? throw new global::System.ArgumentNullException(nameof(scenes));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScenesResponseDto" /> class.
        /// </summary>
        public GetScenesResponseDto()
        {
        }
    }
}