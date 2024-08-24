//HintName: G.Models.CreateUniversalUpscalerJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateUniversalUpscalerJobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("universalUpscaler")]
        public global::G.CreateUniversalUpscalerJobResponseUniversalUpscaler? UniversalUpscaler { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}