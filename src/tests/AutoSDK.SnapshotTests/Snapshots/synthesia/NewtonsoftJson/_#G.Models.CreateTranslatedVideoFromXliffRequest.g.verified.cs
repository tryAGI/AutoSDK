//HintName: G.Models.CreateTranslatedVideoFromXliffRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranslatedVideoFromXliffRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("videoId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid VideoId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("xliffContent", Required = global::Newtonsoft.Json.Required.Always)]
        public string XliffContent { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callbackId")]
        public string? CallbackId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslatedVideoFromXliffRequest" /> class.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="xliffContent"></param>
        /// <param name="callbackId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public CreateTranslatedVideoFromXliffRequest(
            global::System.Guid videoId,
            string xliffContent,
            string? callbackId)
        {
            this.VideoId = videoId;
            this.XliffContent = xliffContent ?? throw new global::System.ArgumentNullException(nameof(xliffContent));
            this.CallbackId = callbackId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslatedVideoFromXliffRequest" /> class.
        /// </summary>
        public CreateTranslatedVideoFromXliffRequest()
        {
        }
    }
}