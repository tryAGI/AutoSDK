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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: 310
        /// </summary>
        /// <example>310</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mcc { get; set; }

        /// <summary>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mnc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mnc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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