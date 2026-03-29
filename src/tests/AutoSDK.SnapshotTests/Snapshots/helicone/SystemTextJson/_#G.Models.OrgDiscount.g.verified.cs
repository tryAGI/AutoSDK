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
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Percent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgDiscount" /> class.
        /// </summary>
        /// <param name="percent"></param>
        /// <param name="provider"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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