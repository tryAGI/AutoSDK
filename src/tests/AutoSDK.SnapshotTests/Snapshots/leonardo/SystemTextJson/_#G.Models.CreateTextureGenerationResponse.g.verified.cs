//HintName: G.Models.CreateTextureGenerationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextureGenerationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textureGenerationJob")]
        public global::G.CreateTextureGenerationResponseTextureGenerationJob? TextureGenerationJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextureGenerationResponse" /> class.
        /// </summary>
        /// <param name="textureGenerationJob"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextureGenerationResponse(
            global::G.CreateTextureGenerationResponseTextureGenerationJob? textureGenerationJob)
        {
            this.TextureGenerationJob = textureGenerationJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextureGenerationResponse" /> class.
        /// </summary>
        public CreateTextureGenerationResponse()
        {
        }
    }
}