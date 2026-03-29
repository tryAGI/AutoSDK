//HintName: G.Models.TrackShareRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrackShareRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TrackShareRequestPlatformJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TrackShareRequestPlatform Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Feature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackShareRequest" /> class.
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="feature"></param>
        /// <param name="email"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackShareRequest(
            global::G.TrackShareRequestPlatform platform,
            string feature,
            string email)
        {
            this.Platform = platform;
            this.Feature = feature ?? throw new global::System.ArgumentNullException(nameof(feature));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackShareRequest" /> class.
        /// </summary>
        public TrackShareRequest()
        {
        }
    }
}