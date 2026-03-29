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
        [global::System.Text.Json.Serialization.JsonPropertyName("videoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid VideoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xliffContent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string XliffContent { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbackId")]
        public string? CallbackId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslatedVideoFromXliffRequest" /> class.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="xliffContent"></param>
        /// <param name="callbackId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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