//HintName: G.Models.CreateVariationNoBGResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVariationNoBGResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sdNobgJob")]
        public global::G.CreateVariationNoBGResponseSdNobgJob? SdNobgJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationNoBGResponse" /> class.
        /// </summary>
        /// <param name="sdNobgJob"></param>
        public CreateVariationNoBGResponse(
            global::G.CreateVariationNoBGResponseSdNobgJob? sdNobgJob)
        {
            this.SdNobgJob = sdNobgJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVariationNoBGResponse" /> class.
        /// </summary>
        public CreateVariationNoBGResponse()
        {
        }
    }
}