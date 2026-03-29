//HintName: G.Models.Datacenter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Datacenter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string CountryCode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Datacenter" /> class.
        /// </summary>
        /// <param name="countryCode"></param>
        public Datacenter(
            string countryCode)
        {
            this.CountryCode = countryCode ?? throw new global::System.ArgumentNullException(nameof(countryCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Datacenter" /> class.
        /// </summary>
        public Datacenter()
        {
        }
    }
}