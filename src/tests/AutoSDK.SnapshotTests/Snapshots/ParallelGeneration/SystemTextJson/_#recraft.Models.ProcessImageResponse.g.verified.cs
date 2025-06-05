//HintName: recraft.Models.ProcessImageResponse.g.cs

#nullable enable

namespace recraft
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessImageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::recraft.Image Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessImageResponse" /> class.
        /// </summary>
        /// <param name="created"></param>
        /// <param name="image"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessImageResponse(
            int created,
            global::recraft.Image image)
        {
            this.Created = created;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessImageResponse" /> class.
        /// </summary>
        public ProcessImageResponse()
        {
        }
    }
}