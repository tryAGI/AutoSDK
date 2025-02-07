//HintName: G.Models.EndGuestStarSessionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndGuestStarSessionResponse
    {
        /// <summary>
        /// Summary of the session details when the session was ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GuestStarSession> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndGuestStarSessionResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Summary of the session details when the session was ended.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndGuestStarSessionResponse(
            global::System.Collections.Generic.IList<global::G.GuestStarSession> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndGuestStarSessionResponse" /> class.
        /// </summary>
        public EndGuestStarSessionResponse()
        {
        }
    }
}