//HintName: G.Models.AccountDetailsV1ResponseCredits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountDetailsV1ResponseCredits
    {
        /// <summary>
        /// The number of credits available<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("available", Required = global::Newtonsoft.Json.Required.Always)]
        public double Available { get; set; } = default!;

        /// <summary>
        /// The number of credits available in the subscription<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("subscription", Required = global::Newtonsoft.Json.Required.Always)]
        public double Subscription { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV1ResponseCredits" /> class.
        /// </summary>
        /// <param name="available">
        /// The number of credits available<br/>
        /// Example: 100
        /// </param>
        /// <param name="subscription">
        /// The number of credits available in the subscription<br/>
        /// Example: 100
        /// </param>
        public AccountDetailsV1ResponseCredits(
            double available,
            double subscription)
        {
            this.Available = available;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsV1ResponseCredits" /> class.
        /// </summary>
        public AccountDetailsV1ResponseCredits()
        {
        }
    }
}