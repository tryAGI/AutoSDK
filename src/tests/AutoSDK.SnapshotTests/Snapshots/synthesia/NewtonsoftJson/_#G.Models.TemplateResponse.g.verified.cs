//HintName: G.Models.TemplateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateResponse
    {
        /// <summary>
        /// Optional folder ID. If provided, the new video will be created under this folder and inherit its permissions.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folderId")]
        public global::System.Guid? FolderId { get; set; }

        /// <summary>
        /// A callback ID that you may attach to the Video object. This is useful in the scenario where you need to store additional metadata on the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callbackId")]
        public string? CallbackId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ctaSettings")]
        public global::G.CtaSettings? CtaSettings { get; set; }

        /// <summary>
        /// Description of the video (used on the video's share page). Defaults to the template description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Unique identifier of the template from which to create this video. This may be retrieved from the templates page in STUDIO.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("templateId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TemplateId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("templateData", Required = global::Newtonsoft.Json.Required.Always)]
        public object TemplateData { get; set; } = default!;

        /// <summary>
        /// Describes if the video is a test video. Test videos do not count towards your quota but are rendered with a watermark.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test")]
        public bool? Test { get; set; }

        /// <summary>
        /// Title of the video (used on the video's share page). Defaults to the template title.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Describes the private settings of the video. - If public, the video's share page is active. - If private, the video's share page is not active; visitors will receive a 404 Not Found response.<br/>
        /// Default Value: private
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplateResponseVisibilityJsonConverter))]
        public global::G.TemplateResponseVisibility? Visibility { get; set; }

        /// <summary>
        /// Brand kit ID for the video. Defaults to 'workspace_default' if not set. Use 'no_brand_kit' for no branding, or a UUID for a custom brand kit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("brandKitId")]
        public string? BrandKitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("download")]
        public string? Download { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUpdatedAt")]
        public int? LastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variables")]
        public global::System.Collections.Generic.IList<object>? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponse" /> class.
        /// </summary>
        /// <param name="templateId">
        /// Unique identifier of the template from which to create this video. This may be retrieved from the templates page in STUDIO.
        /// </param>
        /// <param name="templateData"></param>
        /// <param name="userId"></param>
        /// <param name="folderId">
        /// Optional folder ID. If provided, the new video will be created under this folder and inherit its permissions.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="callbackId">
        /// A callback ID that you may attach to the Video object. This is useful in the scenario where you need to store additional metadata on the video.
        /// </param>
        /// <param name="ctaSettings"></param>
        /// <param name="description">
        /// Description of the video (used on the video's share page). Defaults to the template description.
        /// </param>
        /// <param name="test">
        /// Describes if the video is a test video. Test videos do not count towards your quota but are rendered with a watermark.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="title">
        /// Title of the video (used on the video's share page). Defaults to the template title.
        /// </param>
        /// <param name="visibility">
        /// Describes the private settings of the video. - If public, the video's share page is active. - If private, the video's share page is not active; visitors will receive a 404 Not Found response.<br/>
        /// Default Value: private
        /// </param>
        /// <param name="brandKitId">
        /// Brand kit ID for the video. Defaults to 'workspace_default' if not set. Use 'no_brand_kit' for no branding, or a UUID for a custom brand kit.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="download"></param>
        /// <param name="duration"></param>
        /// <param name="id"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="variables"></param>
        public TemplateResponse(
            global::System.Guid templateId,
            object templateData,
            string userId,
            global::System.Guid? folderId,
            string? callbackId,
            global::G.CtaSettings? ctaSettings,
            string? description,
            bool? test,
            string? title,
            global::G.TemplateResponseVisibility? visibility,
            string? brandKitId,
            int? createdAt,
            string? download,
            string? duration,
            global::System.Guid? id,
            int? lastUpdatedAt,
            global::System.Collections.Generic.IList<object>? variables)
        {
            this.FolderId = folderId;
            this.CallbackId = callbackId;
            this.CtaSettings = ctaSettings;
            this.Description = description;
            this.TemplateId = templateId;
            this.TemplateData = templateData ?? throw new global::System.ArgumentNullException(nameof(templateData));
            this.Test = test;
            this.Title = title;
            this.Visibility = visibility;
            this.BrandKitId = brandKitId;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.CreatedAt = createdAt;
            this.Download = download;
            this.Duration = duration;
            this.Id = id;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponse" /> class.
        /// </summary>
        public TemplateResponse()
        {
        }
    }
}