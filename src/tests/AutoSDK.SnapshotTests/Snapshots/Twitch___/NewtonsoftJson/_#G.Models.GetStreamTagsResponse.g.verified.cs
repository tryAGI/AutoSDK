//HintName: G.Models.GetStreamTagsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GetStreamTagsResponse
    {
        /// <summary>
        /// The list of stream tags. The list is empty if the broadcaster or Twitch hasn’t added tags to the broadcaster’s channel.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.StreamTag> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStreamTagsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of stream tags. The list is empty if the broadcaster or Twitch hasn’t added tags to the broadcaster’s channel.
        /// </param>
        public GetStreamTagsResponse(
            global::System.Collections.Generic.IList<global::G.StreamTag> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStreamTagsResponse" /> class.
        /// </summary>
        public GetStreamTagsResponse()
        {
        }
    }
}