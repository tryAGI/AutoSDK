//HintName: G.Models.ImageGenerationCreateReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageGenerationCreateReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ImageGenerationRequestInputs Inputs { get; set; } = default!;

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Whether to track this image generation call in the trace server<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("track_llm_call")]
        public bool? TrackLlmCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationCreateReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="inputs"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="trackLlmCall">
        /// Whether to track this image generation call in the trace server<br/>
        /// Default Value: true
        /// </param>
        public ImageGenerationCreateReq(
            string projectId,
            global::G.ImageGenerationRequestInputs inputs,
            string? wbUserId,
            bool? trackLlmCall)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.WbUserId = wbUserId;
            this.TrackLlmCall = trackLlmCall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationCreateReq" /> class.
        /// </summary>
        public ImageGenerationCreateReq()
        {
        }
    }
}