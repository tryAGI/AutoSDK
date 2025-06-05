//HintName: G.Models.ConfigOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigOut
    {
        /// <summary>
        /// Spending limit (in USD). Negative means no limit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public double Limit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigOut" /> class.
        /// </summary>
        /// <param name="limit">
        /// Spending limit (in USD). Negative means no limit
        /// </param>
        public ConfigOut(
            double limit)
        {
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigOut" /> class.
        /// </summary>
        public ConfigOut()
        {
        }
    }
}