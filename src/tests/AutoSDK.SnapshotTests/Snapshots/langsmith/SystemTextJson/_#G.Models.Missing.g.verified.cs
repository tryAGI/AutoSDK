//HintName: G.Models.Missing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Missing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("__missing__")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Missing1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Missing" /> class.
        /// </summary>
        /// <param name="missing1"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Missing(
            string missing1)
        {
            this.Missing1 = missing1 ?? throw new global::System.ArgumentNullException(nameof(missing1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Missing" /> class.
        /// </summary>
        public Missing()
        {
        }
    }
}