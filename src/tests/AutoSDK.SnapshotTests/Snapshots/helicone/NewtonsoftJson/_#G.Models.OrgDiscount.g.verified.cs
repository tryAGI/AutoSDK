//HintName: G.Models.OrgDiscount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgDiscount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("percent", Required = global::Newtonsoft.Json.Required.Always)]
        public double Percent { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgDiscount" /> class.
        /// </summary>
        /// <param name="percent"></param>
        /// <param name="provider"></param>
        /// <param name="model"></param>
        public OrgDiscount(
            double percent,
            string? provider,
            string? model)
        {
            this.Provider = provider;
            this.Model = model;
            this.Percent = percent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgDiscount" /> class.
        /// </summary>
        public OrgDiscount()
        {
        }
    }
}