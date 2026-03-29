//HintName: G.Models.PercentageValueStatPublicVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PercentageValueStatPublicVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public global::G.PercentageValuesPublic? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentageValueStatPublicVariant2" /> class.
        /// </summary>
        /// <param name="value"></param>
        public PercentageValueStatPublicVariant2(
            global::G.PercentageValuesPublic? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentageValueStatPublicVariant2" /> class.
        /// </summary>
        public PercentageValueStatPublicVariant2()
        {
        }
    }
}