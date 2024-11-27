//HintName: G.Models.UpdateTagAppWeightRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTagAppWeightRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currentProjectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid CurrentProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagAppId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TagAppId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newWeight", Required = global::Newtonsoft.Json.Required.Always)]
        public double NewWeight { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTagAppWeightRequest" /> class.
        /// </summary>
        /// <param name="currentProjectId"></param>
        /// <param name="tagAppId"></param>
        /// <param name="newWeight"></param>
        public UpdateTagAppWeightRequest(
            global::System.Guid currentProjectId,
            global::System.Guid tagAppId,
            double newWeight)
        {
            this.CurrentProjectId = currentProjectId;
            this.TagAppId = tagAppId;
            this.NewWeight = newWeight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTagAppWeightRequest" /> class.
        /// </summary>
        public UpdateTagAppWeightRequest()
        {
        }
    }
}