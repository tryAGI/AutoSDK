//HintName: G.Models.Generation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The generation response object<br/>
    /// Example: {"id":"123e4567-e89b-12d3-a456-426614174000","state":"completed","failure_reason":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","created_at":"2023-06-01T12:00:00Z","assets":{"video":"https://example.com/video.mp4"},"model":"ray-1-6","request":{"prompt":"A serene lake surrounded by mountains at sunset","aspect_ratio":"16:9","loop":true,"keyframes":{"frame0":{"type":"image","url":"https://example.com/image.jpg"},"frame1":{"type":"generation","id":"123e4567-e89b-12d3-a456-426614174000"}}}}
    /// </summary>
    public sealed partial class Generation
    {
        /// <summary>
        /// The ID of the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The type of the generation<br/>
        /// Default Value: video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_type")]
        public global::G.GenerationType? GenerationType { get; set; }

        /// <summary>
        /// The state of the generation<br/>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.State? State { get; set; }

        /// <summary>
        /// The reason for the state of the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failure_reason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// The date and time when the generation was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The assets of the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assets")]
        public global::G.Assets? Assets { get; set; }

        /// <summary>
        /// The model used for the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The request of the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request")]
        public global::G.Request? Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the generation
        /// </param>
        /// <param name="generationType">
        /// The type of the generation<br/>
        /// Default Value: video
        /// </param>
        /// <param name="state">
        /// The state of the generation<br/>
        /// Example: completed
        /// </param>
        /// <param name="failureReason">
        /// The reason for the state of the generation
        /// </param>
        /// <param name="createdAt">
        /// The date and time when the generation was created
        /// </param>
        /// <param name="assets">
        /// The assets of the generation
        /// </param>
        /// <param name="model">
        /// The model used for the generation
        /// </param>
        /// <param name="request">
        /// The request of the generation
        /// </param>
        public Generation(
            global::System.Guid? id,
            global::G.GenerationType? generationType,
            global::G.State? state,
            string? failureReason,
            global::System.DateTime? createdAt,
            global::G.Assets? assets,
            string? model,
            global::G.Request? request)
        {
            this.Id = id;
            this.GenerationType = generationType;
            this.State = state;
            this.FailureReason = failureReason;
            this.CreatedAt = createdAt;
            this.Assets = assets;
            this.Model = model;
            this.Request = request;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        public Generation()
        {
        }
    }
}