//HintName: G.Models.CreateVariationUpscaleResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVariationUpscaleResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sdUpscaleJob")]
        public global::G.CreateVariationUpscaleResponseSdUpscaleJob? SdUpscaleJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationUpscaleResponse" /> class.
        /// </summary>
        /// <param name="sdUpscaleJob"></param>
        public CreateVariationUpscaleResponse(
            global::G.CreateVariationUpscaleResponseSdUpscaleJob? sdUpscaleJob)
        {
            this.SdUpscaleJob = sdUpscaleJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationUpscaleResponse" /> class.
        /// </summary>
        public CreateVariationUpscaleResponse()
        {
        }
    }
}