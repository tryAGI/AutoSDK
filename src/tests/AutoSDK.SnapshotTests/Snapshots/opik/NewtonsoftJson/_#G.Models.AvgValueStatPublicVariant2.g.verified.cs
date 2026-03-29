//HintName: G.Models.AvgValueStatPublicVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AvgValueStatPublicVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvgValueStatPublicVariant2" /> class.
        /// </summary>
        /// <param name="value"></param>
        public AvgValueStatPublicVariant2(
            double? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvgValueStatPublicVariant2" /> class.
        /// </summary>
        public AvgValueStatPublicVariant2()
        {
        }
    }
}