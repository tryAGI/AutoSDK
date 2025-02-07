//HintName: G.Models.ChangePaymentPlanSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Change payment plan schema.
    /// </summary>
    public sealed partial class ChangePaymentPlanSchema
    {
        /// <summary>
        /// Enum for payment plans that the user can change to. Developer plans are permanent and enterprise plans will be changed manually.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChangePaymentPlanReqJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChangePaymentPlanReq Tier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePaymentPlanSchema" /> class.
        /// </summary>
        /// <param name="tier">
        /// Enum for payment plans that the user can change to. Developer plans are permanent and enterprise plans will be changed manually.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChangePaymentPlanSchema(
            global::G.ChangePaymentPlanReq tier)
        {
            this.Tier = tier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePaymentPlanSchema" /> class.
        /// </summary>
        public ChangePaymentPlanSchema()
        {
        }
    }
}