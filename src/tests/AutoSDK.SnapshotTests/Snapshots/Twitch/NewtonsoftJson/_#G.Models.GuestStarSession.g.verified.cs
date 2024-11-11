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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// List of guests currently interacting with the Guest Star session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Guest> Guests { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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