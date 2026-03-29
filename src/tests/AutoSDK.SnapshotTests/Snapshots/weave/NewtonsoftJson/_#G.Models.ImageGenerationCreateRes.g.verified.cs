//HintName: G.Models.ImageGenerationCreateRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageGenerationCreateRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public object Response { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weave_call_id")]
        public string? WeaveCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationCreateRes" /> class.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="weaveCallId"></param>
        public ImageGenerationCreateRes(
            object response,
            string? weaveCallId)
        {
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.WeaveCallId = weaveCallId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationCreateRes" /> class.
        /// </summary>
        public ImageGenerationCreateRes()
        {
        }
    }
}