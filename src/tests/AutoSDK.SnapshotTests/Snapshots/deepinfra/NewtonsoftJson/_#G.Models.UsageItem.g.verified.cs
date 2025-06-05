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
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelMeta Model { get; set; } = default!;

        /// <summary>
        /// billed seconds or tokens
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("units", Required = global::Newtonsoft.Json.Required.Always)]
        public int Units { get; set; } = default!;

        /// <summary>
        /// rate in cents/sec or cents per token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate", Required = global::Newtonsoft.Json.Required.Always)]
        public double Rate { get; set; } = default!;

        /// <summary>
        /// model cost in cents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public int Cost { get; set; } = default!;

        /// <summary>
        /// pricing type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pricing_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string PricingType { get; set; } = default!;

        /// <summary>
        /// Inclusive, in ms
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TimeInterval Interval { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// Inclusive, in ms
        /// </param>
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