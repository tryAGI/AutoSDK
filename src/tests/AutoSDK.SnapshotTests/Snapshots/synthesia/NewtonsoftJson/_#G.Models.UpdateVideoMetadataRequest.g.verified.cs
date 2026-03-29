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
        [global::Newtonsoft.Json.JsonProperty("ctaSettings")]
        public global::G.CtaSettings? CtaSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility")]
        public global::G.UpdateVideoMetadataRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVideoMetadataRequest" /> class.
        /// </summary>
        /// <param name="ctaSettings"></param>
        /// <param name="description"></param>
        /// <param name="title"></param>
        /// <param name="visibility"></param>
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