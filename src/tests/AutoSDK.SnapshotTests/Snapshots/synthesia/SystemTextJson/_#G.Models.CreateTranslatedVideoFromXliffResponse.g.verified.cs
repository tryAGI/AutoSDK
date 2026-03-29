//HintName: G.Models.CreateTranslatedVideoFromXliffResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranslatedVideoFromXliffResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslatedVideoFromXliffResponse" /> class.
        /// </summary>
        /// <param name="videoId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTranslatedVideoFromXliffResponse(
            string videoId)
        {
            this.VideoId = videoId ?? throw new global::System.ArgumentNullException(nameof(videoId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslatedVideoFromXliffResponse" /> class.
        /// </summary>
        public CreateTranslatedVideoFromXliffResponse()
        {
        }
    }
}