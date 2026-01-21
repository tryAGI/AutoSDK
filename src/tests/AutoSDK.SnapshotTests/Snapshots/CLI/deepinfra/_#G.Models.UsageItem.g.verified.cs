//HintName: G.Models.UsageItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelMeta Model { get; set; }

        /// <summary>
        /// billed seconds or tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Units { get; set; }

        /// <summary>
        /// rate in cents/sec or cents per token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rate { get; set; }

        /// <summary>
        /// model cost in cents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Cost { get; set; }

        /// <summary>
        /// pricing type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PricingType { get; set; }

        /// <summary>
        /// time interval with this particular pricing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TimeInterval Interval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageItem" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="units">
        /// billed seconds or tokens
        /// </param>
        /// <param name="rate">
        /// rate in cents/sec or cents per token
        /// </param>
        /// <param name="cost">
        /// model cost in cents
        /// </param>
        /// <param name="pricingType">
        /// pricing type
        /// </param>
        /// <param name="interval">
        /// time interval with this particular pricing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageItem(
            global::G.ModelMeta model,
            int units,
            double rate,
            int cost,
            string pricingType,
            global::G.TimeInterval interval)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Units = units;
            this.Rate = rate;
            this.Cost = cost;
            this.PricingType = pricingType ?? throw new global::System.ArgumentNullException(nameof(pricingType));
            this.Interval = interval ?? throw new global::System.ArgumentNullException(nameof(interval));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageItem" /> class.
        /// </summary>
        public UsageItem()
        {
        }
    }
}