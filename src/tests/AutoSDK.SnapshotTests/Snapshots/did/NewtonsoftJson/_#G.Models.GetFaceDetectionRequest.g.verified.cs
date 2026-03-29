//HintName: G.Models.GetFaceDetectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFaceDetectionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("should_skip_detection")]
        public bool? ShouldSkipDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFaceDetectionRequest" /> class.
        /// </summary>
        /// <param name="sourceUrl"></param>
        /// <param name="shouldSkipDetection"></param>
        public GetFaceDetectionRequest(
            string sourceUrl,
            bool? shouldSkipDetection)
        {
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
            this.ShouldSkipDetection = shouldSkipDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFaceDetectionRequest" /> class.
        /// </summary>
        public GetFaceDetectionRequest()
        {
        }
    }
}