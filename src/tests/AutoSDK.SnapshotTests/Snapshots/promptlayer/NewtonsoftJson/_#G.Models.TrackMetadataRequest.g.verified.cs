//HintName: G.Models.TrackMetadataRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrackMetadataRequest
    {
        /// <summary>
        /// The unique identifier for the request to which the metadata is associated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; } = default!;

        /// <summary>
        /// A dictionary of metadata items to associate with the request. Can include session_ids, user_ids, location, etc.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public object Metadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackMetadataRequest" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The unique identifier for the request to which the metadata is associated.
        /// </param>
        /// <param name="metadata">
        /// A dictionary of metadata items to associate with the request. Can include session_ids, user_ids, location, etc.
        /// </param>
        public TrackMetadataRequest(
            int requestId,
            object metadata)
        {
            this.RequestId = requestId;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackMetadataRequest" /> class.
        /// </summary>
        public TrackMetadataRequest()
        {
        }
    }
}