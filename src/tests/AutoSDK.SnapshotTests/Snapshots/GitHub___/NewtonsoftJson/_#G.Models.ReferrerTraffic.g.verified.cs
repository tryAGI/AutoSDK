//HintName: G.Models.ReferrerTraffic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Referrer Traffic
    /// </summary>
    public sealed partial class ReferrerTraffic
    {
        /// <summary>
        /// Example: Google
        /// </summary>
        /// <example>Google</example>
        [global::Newtonsoft.Json.JsonProperty("referrer", Required = global::Newtonsoft.Json.Required.Always)]
        public string Referrer { get; set; } = default!;

        /// <summary>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::Newtonsoft.Json.JsonProperty("uniques", Required = global::Newtonsoft.Json.Required.Always)]
        public int Uniques { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferrerTraffic" /> class.
        /// </summary>
        /// <param name="referrer">
        /// Example: Google
        /// </param>
        /// <param name="count">
        /// Example: 4
        /// </param>
        /// <param name="uniques">
        /// Example: 3
        /// </param>
        public ReferrerTraffic(
            string referrer,
            int count,
            int uniques)
        {
            this.Referrer = referrer ?? throw new global::System.ArgumentNullException(nameof(referrer));
            this.Count = count;
            this.Uniques = uniques;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferrerTraffic" /> class.
        /// </summary>
        public ReferrerTraffic()
        {
        }
    }
}