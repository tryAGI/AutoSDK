//HintName: G.Models.CountValueStatPublicVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CountValueStatPublicVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public long? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountValueStatPublicVariant2" /> class.
        /// </summary>
        /// <param name="value"></param>
        public CountValueStatPublicVariant2(
            long? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountValueStatPublicVariant2" /> class.
        /// </summary>
        public CountValueStatPublicVariant2()
        {
        }
    }
}