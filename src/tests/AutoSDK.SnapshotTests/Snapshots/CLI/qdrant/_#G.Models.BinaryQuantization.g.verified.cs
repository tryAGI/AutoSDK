//HintName: G.Models.BinaryQuantization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BinaryQuantization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("binary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BinaryQuantizationConfig Binary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryQuantization" /> class.
        /// </summary>
        /// <param name="binary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BinaryQuantization(
            global::G.BinaryQuantizationConfig binary)
        {
            this.Binary = binary ?? throw new global::System.ArgumentNullException(nameof(binary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryQuantization" /> class.
        /// </summary>
        public BinaryQuantization()
        {
        }
    }
}