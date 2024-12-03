//HintName: G.Models.CreateVariationUnzoomResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVariationUnzoomResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdUnzoomJob")]
        public global::G.CreateVariationUnzoomResponseSdUnzoomJob? SdUnzoomJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationUnzoomResponse" /> class.
        /// </summary>
        /// <param name="sdUnzoomJob"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateVariationUnzoomResponse(
            global::G.CreateVariationUnzoomResponseSdUnzoomJob? sdUnzoomJob)
        {
            this.SdUnzoomJob = sdUnzoomJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationUnzoomResponse" /> class.
        /// </summary>
        public CreateVariationUnzoomResponse()
        {
        }
    }
}