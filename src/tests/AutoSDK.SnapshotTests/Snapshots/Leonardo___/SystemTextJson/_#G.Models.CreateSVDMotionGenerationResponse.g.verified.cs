//HintName: G.Models.CreateSVDMotionGenerationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSVDMotionGenerationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdGenerationJob")]
        public global::G.CreateSVDMotionGenerationResponseSdGenerationJob? SdGenerationJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSVDMotionGenerationResponse" /> class.
        /// </summary>
        /// <param name="sdGenerationJob"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateSVDMotionGenerationResponse(
            global::G.CreateSVDMotionGenerationResponseSdGenerationJob? sdGenerationJob)
        {
            this.SdGenerationJob = sdGenerationJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSVDMotionGenerationResponse" /> class.
        /// </summary>
        public CreateSVDMotionGenerationResponse()
        {
        }
    }
}