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
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Response { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weave_call_id")]
        public string? WeaveCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationCreateRes" /> class.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="weaveCallId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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