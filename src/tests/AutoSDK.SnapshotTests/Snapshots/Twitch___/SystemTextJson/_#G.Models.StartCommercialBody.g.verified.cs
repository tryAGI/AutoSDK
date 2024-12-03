//HintName: G.Models.StartCommercialBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartCommercialBody
    {
        /// <summary>
        /// The ID of the partner or affiliate broadcaster that wants to run the commercial. This ID must match the user ID found in the OAuth token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The length of the commercial to run, in seconds. Twitch tries to serve a commercial that’s the requested length, but it may be shorter or longer. The maximum length you should request is 180 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Length { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartCommercialBody" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// The ID of the partner or affiliate broadcaster that wants to run the commercial. This ID must match the user ID found in the OAuth token.
        /// </param>
        /// <param name="length">
        /// The length of the commercial to run, in seconds. Twitch tries to serve a commercial that’s the requested length, but it may be shorter or longer. The maximum length you should request is 180 seconds.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StartCommercialBody(
            string broadcasterId,
            int length)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.Length = length;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartCommercialBody" /> class.
        /// </summary>
        public StartCommercialBody()
        {
        }
    }
}