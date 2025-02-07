//HintName: G.Models.CustomerVisiblePlanInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Customer visible plan information.
    /// </summary>
    public sealed partial class CustomerVisiblePlanInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PaymentPlanTierJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PaymentPlanTier Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ends_on")]
        public global::System.DateTime? EndsOn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerVisiblePlanInfo" /> class.
        /// </summary>
        /// <param name="tier"></param>
        /// <param name="startedOn"></param>
        /// <param name="endsOn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerVisiblePlanInfo(
            global::G.PaymentPlanTier tier,
            global::System.DateTime startedOn,
            global::System.DateTime? endsOn)
        {
            this.Tier = tier;
            this.StartedOn = startedOn;
            this.EndsOn = endsOn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerVisiblePlanInfo" /> class.
        /// </summary>
        public CustomerVisiblePlanInfo()
        {
        }
    }
}