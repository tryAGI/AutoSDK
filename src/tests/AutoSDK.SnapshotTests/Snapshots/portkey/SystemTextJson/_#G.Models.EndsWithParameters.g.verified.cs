//HintName: G.Models.EndsWithParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndsWithParameters
    {
        /// <summary>
        /// Suffix to check for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Suffix { get; set; }

        /// <summary>
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not")]
        public bool? Not { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndsWithParameters" /> class.
        /// </summary>
        /// <param name="suffix">
        /// Suffix to check for
        /// </param>
        /// <param name="not">
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndsWithParameters(
            string suffix,
            bool? not)
        {
            this.Suffix = suffix ?? throw new global::System.ArgumentNullException(nameof(suffix));
            this.Not = not;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndsWithParameters" /> class.
        /// </summary>
        public EndsWithParameters()
        {
        }
    }
}