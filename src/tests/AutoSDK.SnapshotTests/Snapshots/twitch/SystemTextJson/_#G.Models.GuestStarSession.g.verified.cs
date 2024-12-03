//HintName: G.Models.GuestStarSession.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuestStarSession
    {
        /// <summary>
        /// ID uniquely representing the Guest Star session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// List of guests currently interacting with the Guest Star session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Guest> Guests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuestStarSession" /> class.
        /// </summary>
        /// <param name="id">
        /// ID uniquely representing the Guest Star session.
        /// </param>
        /// <param name="guests">
        /// List of guests currently interacting with the Guest Star session.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GuestStarSession(
            string id,
            global::System.Collections.Generic.IList<global::G.Guest> guests)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Guests = guests ?? throw new global::System.ArgumentNullException(nameof(guests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuestStarSession" /> class.
        /// </summary>
        public GuestStarSession()
        {
        }
    }
}