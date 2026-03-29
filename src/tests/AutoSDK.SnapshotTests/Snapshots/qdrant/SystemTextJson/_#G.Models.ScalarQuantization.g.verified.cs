//HintName: G.Models.ScalarQuantization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScalarQuantization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scalar")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ScalarQuantizationConfig Scalar { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalarQuantization" /> class.
        /// </summary>
        /// <param name="scalar"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScalarQuantization(
            global::G.ScalarQuantizationConfig scalar)
        {
            this.Scalar = scalar ?? throw new global::System.ArgumentNullException(nameof(scalar));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalarQuantization" /> class.
        /// </summary>
        public ScalarQuantization()
        {
        }
    }
}