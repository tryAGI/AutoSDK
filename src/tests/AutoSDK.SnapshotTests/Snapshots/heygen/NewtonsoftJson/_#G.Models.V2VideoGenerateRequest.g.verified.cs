//HintName: G.Models.V2VideoGenerateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2VideoGenerateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aspect_ratio")]
        public object? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_id")]
        public object? CallbackId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dimension")]
        public global::G.V2VideoGenerateRequestDimension? Dimension { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("test")]
        public bool? Test { get; set; }

        /// <summary>
        /// Example: My Title
        /// </summary>
        /// <example>My Title</example>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::Newtonsoft.Json.JsonProperty("video_inputs")]
        public global::System.Collections.Generic.IList<global::G.V2VideoGenerateRequestVideoInput>? VideoInputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequest" /> class.
        /// </summary>
        /// <param name="aspectRatio"></param>
        /// <param name="callbackId"></param>
        /// <param name="dimension"></param>
        /// <param name="test">
        /// Example: true
        /// </param>
        /// <param name="title">
        /// Example: My Title
        /// </param>
        /// <param name="videoInputs">
        /// Example: []
        /// </param>
        public V2VideoGenerateRequest(
            object? aspectRatio,
            object? callbackId,
            global::G.V2VideoGenerateRequestDimension? dimension,
            bool? test,
            string? title,
            global::System.Collections.Generic.IList<global::G.V2VideoGenerateRequestVideoInput>? videoInputs)
        {
            this.AspectRatio = aspectRatio;
            this.CallbackId = callbackId;
            this.Dimension = dimension;
            this.Test = test;
            this.Title = title;
            this.VideoInputs = videoInputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequest" /> class.
        /// </summary>
        public V2VideoGenerateRequest()
        {
        }
    }
}