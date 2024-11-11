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
        [global::Newtonsoft.Json.JsonProperty("tier", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChangePaymentPlanReq Tier { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePaymentPlanSchema" /> class.
        /// </summary>
        /// <param name="tier">
        /// Enum for payment plans that the user can change to. Developer plans are permanent and enterprise plans will be changed manually.
        /// </param>
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