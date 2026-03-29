//HintName: G.Models.RateLimits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimits
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rpm")]
        public double? Rpm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tpm")]
        public double? Tpm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tpd")]
        public double? Tpd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimits" /> class.
        /// </summary>
        /// <param name="rpm"></param>
        /// <param name="tpm"></param>
        /// <param name="tpd"></param>
        public RateLimits(
            double? rpm,
            double? tpm,
            double? tpd)
        {
            this.Rpm = rpm;
            this.Tpm = tpm;
            this.Tpd = tpd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimits" /> class.
        /// </summary>
        public RateLimits()
        {
        }
    }
}