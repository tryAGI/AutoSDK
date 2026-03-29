//HintName: G.Models.PartialRequestResponseRMTToOperatorsPropertyKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PartialRequestResponseRMTToOperatorsPropertyKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("equals", Required = global::Newtonsoft.Json.Required.Always)]
        public string EqualsValue { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRequestResponseRMTToOperatorsPropertyKey" /> class.
        /// </summary>
        /// <param name="equalsValue"></param>
        public PartialRequestResponseRMTToOperatorsPropertyKey(
            string equalsValue)
        {
            this.EqualsValue = equalsValue ?? throw new global::System.ArgumentNullException(nameof(equalsValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRequestResponseRMTToOperatorsPropertyKey" /> class.
        /// </summary>
        public PartialRequestResponseRMTToOperatorsPropertyKey()
        {
        }
    }
}