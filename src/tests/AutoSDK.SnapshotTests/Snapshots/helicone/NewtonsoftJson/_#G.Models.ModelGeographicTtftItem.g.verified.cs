//HintName: G.Models.ModelGeographicTtftItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelGeographicTtftItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("median", Required = global::Newtonsoft.Json.Required.Always)]
        public double Median { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("countryCode", Required = global::Newtonsoft.Json.Required.Always)]
        public string CountryCode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelGeographicTtftItem" /> class.
        /// </summary>
        /// <param name="median"></param>
        /// <param name="countryCode"></param>
        public ModelGeographicTtftItem(
            double median,
            string countryCode)
        {
            this.Median = median;
            this.CountryCode = countryCode ?? throw new global::System.ArgumentNullException(nameof(countryCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelGeographicTtftItem" /> class.
        /// </summary>
        public ModelGeographicTtftItem()
        {
        }
    }
}