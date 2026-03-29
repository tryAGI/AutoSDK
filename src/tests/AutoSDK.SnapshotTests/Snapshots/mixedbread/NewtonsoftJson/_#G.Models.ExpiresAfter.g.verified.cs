//HintName: G.Models.ExpiresAfter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents an expiration policy for a store.
    /// </summary>
    public sealed partial class ExpiresAfter
    {
        /// <summary>
        /// Anchor date for the expiration policy<br/>
        /// Default Value: last_active_at
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("anchor")]
        public string? Anchor { get; set; }

        /// <summary>
        /// Number of days after which the store expires<br/>
        /// Default Value: 30
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("days")]
        public int? Days { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiresAfter" /> class.
        /// </summary>
        /// <param name="anchor">
        /// Anchor date for the expiration policy<br/>
        /// Default Value: last_active_at
        /// </param>
        /// <param name="days">
        /// Number of days after which the store expires<br/>
        /// Default Value: 30
        /// </param>
        public ExpiresAfter(
            string? anchor,
            int? days)
        {
            this.Anchor = anchor;
            this.Days = days;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiresAfter" /> class.
        /// </summary>
        public ExpiresAfter()
        {
        }
    }
}