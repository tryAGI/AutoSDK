//HintName: G.Models.LocationResultContact.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contact information.
    /// </summary>
    public sealed partial class LocationResultContact
    {
        /// <summary>
        /// Email address.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Phone number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("telephone")]
        public string? Telephone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultContact" /> class.
        /// </summary>
        /// <param name="email">
        /// Email address.
        /// </param>
        /// <param name="telephone">
        /// Phone number.
        /// </param>
        public LocationResultContact(
            string? email,
            string? telephone)
        {
            this.Email = email;
            this.Telephone = telephone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultContact" /> class.
        /// </summary>
        public LocationResultContact()
        {
        }
    }
}