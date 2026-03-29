//HintName: G.Models.UpdateVideoMetadataRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateVideoMetadataRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ctaSettings")]
        public global::G.CtaSettings? CtaSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateVideoMetadataRequestVisibilityJsonConverter))]
        public global::G.UpdateVideoMetadataRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVideoMetadataRequest" /> class.
        /// </summary>
        /// <param name="ctaSettings"></param>
        /// <param name="description"></param>
        /// <param name="title"></param>
        /// <param name="visibility"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVideoMetadataRequest(
            global::G.CtaSettings? ctaSettings,
            string? description,
            string? title,
            global::G.UpdateVideoMetadataRequestVisibility? visibility)
        {
            this.CtaSettings = ctaSettings;
            this.Description = description;
            this.Title = title;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVideoMetadataRequest" /> class.
        /// </summary>
        public UpdateVideoMetadataRequest()
        {
        }
    }
}