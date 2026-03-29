//HintName: G.Models.Transfer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The asset URL to fetch and transfer to a destination.
    /// </summary>
    public sealed partial class Transfer
    {
        /// <summary>
        /// The file URL to fetch and transfer.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/video.mp4
        /// </summary>
        /// <example>https://s3-ap-northeast-1.amazonaws.com/my-bucket/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// An identifier for the asset which must be provided by the client. The identifier does not need to be unique.<br/>
        /// Example: 018e8937-5015-75ee-aab6-03f214981133
        /// </summary>
        /// <example>018e8937-5015-75ee-aab6-03f214981133</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Specify the storage locations and hosting services to send the file to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Destinations> Destinations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer" /> class.
        /// </summary>
        /// <param name="url">
        /// The file URL to fetch and transfer.<br/>
        /// Example: https://s3-ap-northeast-1.amazonaws.com/my-bucket/video.mp4
        /// </param>
        /// <param name="id">
        /// An identifier for the asset which must be provided by the client. The identifier does not need to be unique.<br/>
        /// Example: 018e8937-5015-75ee-aab6-03f214981133
        /// </param>
        /// <param name="destinations">
        /// Specify the storage locations and hosting services to send the file to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Transfer(
            string url,
            string id,
            global::System.Collections.Generic.IList<global::G.Destinations> destinations)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Destinations = destinations ?? throw new global::System.ArgumentNullException(nameof(destinations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transfer" /> class.
        /// </summary>
        public Transfer()
        {
        }
    }
}