//HintName: G.Models.PerformAlchemyUpscaleLCMResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PerformAlchemyUpscaleLCMResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lcmGenerationJob")]
        public global::G.PerformAlchemyUpscaleLCMResponseLcmGenerationJob? LcmGenerationJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformAlchemyUpscaleLCMResponse" /> class.
        /// </summary>
        /// <param name="lcmGenerationJob"></param>
        public PerformAlchemyUpscaleLCMResponse(
            global::G.PerformAlchemyUpscaleLCMResponseLcmGenerationJob? lcmGenerationJob)
        {
            this.LcmGenerationJob = lcmGenerationJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformAlchemyUpscaleLCMResponse" /> class.
        /// </summary>
        public PerformAlchemyUpscaleLCMResponse()
        {
        }
    }
}