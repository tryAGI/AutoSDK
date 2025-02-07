//HintName: G.Models.GetGuestStarInvitesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetGuestStarInvitesResponse
    {
        /// <summary>
        /// A list of invite objects describing the invited user as well as their ready status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GuestStarInvite> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGuestStarInvitesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list of invite objects describing the invited user as well as their ready status.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetGuestStarInvitesResponse(
            global::System.Collections.Generic.IList<global::G.GuestStarInvite> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGuestStarInvitesResponse" /> class.
        /// </summary>
        public GetGuestStarInvitesResponse()
        {
        }
    }
}