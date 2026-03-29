//HintName: G.Models.PutProvidersRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutProvidersRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </summary>
        /// <example>{"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}</example>
        [global::Newtonsoft.Json.JsonProperty("usage_limits")]
        public global::G.UsageLimits? UsageLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate_limits")]
        public global::G.RateLimits? RateLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reset_usage")]
        public bool? ResetUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutProvidersRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="note"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="expiresAt"></param>
        /// <param name="resetUsage"></param>
        public PutProvidersRequest(
            string? name,
            string? note,
            global::G.UsageLimits? usageLimits,
            global::G.RateLimits? rateLimits,
            global::System.DateTime? expiresAt,
            bool? resetUsage)
        {
            this.Name = name;
            this.Note = note;
            this.UsageLimits = usageLimits;
            this.RateLimits = rateLimits;
            this.ExpiresAt = expiresAt;
            this.ResetUsage = resetUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutProvidersRequest" /> class.
        /// </summary>
        public PutProvidersRequest()
        {
        }
    }
}