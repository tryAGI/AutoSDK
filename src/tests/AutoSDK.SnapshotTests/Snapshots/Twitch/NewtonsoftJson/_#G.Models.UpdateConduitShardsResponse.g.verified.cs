//HintName: G.Models.UpdateConduitShardsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConduitShardsResponse
    {
        /// <summary>
        /// List of successful shard updates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UpdateConduitShardsResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// List of unsuccessful updates.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UpdateConduitShardsResponseError> Errors { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitShardsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of successful shard updates.
        /// </param>
        /// <param name="errors">
        /// List of unsuccessful updates.
        /// </param>
        public UpdateConduitShardsResponse(
            global::System.Collections.Generic.IList<global::G.UpdateConduitShardsResponseDataItem> data,
            global::System.Collections.Generic.IList<global::G.UpdateConduitShardsResponseError> errors)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConduitShardsResponse" /> class.
        /// </summary>
        public UpdateConduitShardsResponse()
        {
        }
    }
}