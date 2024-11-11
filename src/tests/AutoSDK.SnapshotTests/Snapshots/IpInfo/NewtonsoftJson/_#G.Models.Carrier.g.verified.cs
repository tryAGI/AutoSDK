//HintName: G.Models.Carrier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Carrier
    {
        /// <summary>
        /// Example: Sprint Corporation
        /// </summary>
        /// <example>Sprint Corporation</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: 310
        /// </summary>
        /// <example>310</example>
        [global::Newtonsoft.Json.JsonProperty("mcc", Required = global::Newtonsoft.Json.Required.Always)]
        public string Mcc { get; set; } = default!;

        /// <summary>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::Newtonsoft.Json.JsonProperty("mnc", Required = global::Newtonsoft.Json.Required.Always)]
        public string Mnc { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Carrier" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: Sprint Corporation
        /// </param>
        /// <param name="mcc">
        /// Example: 310
        /// </param>
        /// <param name="mnc">
        /// Example: 120
        /// </param>
        public Carrier(
            string name,
            string mcc,
            string mnc)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Mcc = mcc ?? throw new global::System.ArgumentNullException(nameof(mcc));
            this.Mnc = mnc ?? throw new global::System.ArgumentNullException(nameof(mnc));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Carrier" /> class.
        /// </summary>
        public Carrier()
        {
        }
    }
}