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
        [global::System.Text.Json.Serialization.JsonPropertyName("currentProjectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CurrentProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagAppId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TagAppId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newWeight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NewWeight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTagAppWeightRequest" /> class.
        /// </summary>
        /// <param name="currentProjectId"></param>
        /// <param name="tagAppId"></param>
        /// <param name="newWeight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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