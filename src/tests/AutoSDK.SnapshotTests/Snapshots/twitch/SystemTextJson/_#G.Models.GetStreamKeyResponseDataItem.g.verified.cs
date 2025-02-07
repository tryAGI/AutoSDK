//HintName: G.Models.GetStreamKeyResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetStreamKeyResponseDataItem
    {
        /// <summary>
        /// The channel’s stream key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StreamKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStreamKeyResponseDataItem" /> class.
        /// </summary>
        /// <param name="streamKey">
        /// The channel’s stream key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetStreamKeyResponseDataItem(
            string streamKey)
        {
            this.StreamKey = streamKey ?? throw new global::System.ArgumentNullException(nameof(streamKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStreamKeyResponseDataItem" /> class.
        /// </summary>
        public GetStreamKeyResponseDataItem()
        {
        }
    }
}