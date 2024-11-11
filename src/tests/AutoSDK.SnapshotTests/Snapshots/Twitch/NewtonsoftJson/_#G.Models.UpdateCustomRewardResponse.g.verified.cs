//HintName: G.Models.UpdateCustomRewardResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCustomRewardResponse
    {
        /// <summary>
        /// The list contains the single reward that you updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CustomReward> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomRewardResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list contains the single reward that you updated.
        /// </param>
        public UpdateCustomRewardResponse(
            global::System.Collections.Generic.IList<global::G.CustomReward> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomRewardResponse" /> class.
        /// </summary>
        public UpdateCustomRewardResponse()
        {
        }
    }
}