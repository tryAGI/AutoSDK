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
        [global::System.Text.Json.Serialization.JsonPropertyName("equals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EqualsValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialRequestResponseRMTToOperatorsPropertyKey" /> class.
        /// </summary>
        /// <param name="equalsValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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