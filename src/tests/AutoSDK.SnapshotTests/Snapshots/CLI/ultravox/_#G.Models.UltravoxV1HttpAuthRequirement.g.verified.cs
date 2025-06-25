//HintName: G.Models.UltravoxV1HttpAuthRequirement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A security requirement that will cause an HTTP authentication header to be added.
    /// </summary>
    public sealed partial class UltravoxV1HttpAuthRequirement
    {
        /// <summary>
        /// The scheme of the HTTP authentication, e.g. "Bearer".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheme")]
        public string? Scheme { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1HttpAuthRequirement" /> class.
        /// </summary>
        /// <param name="scheme">
        /// The scheme of the HTTP authentication, e.g. "Bearer".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1HttpAuthRequirement(
            string? scheme)
        {
            this.Scheme = scheme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1HttpAuthRequirement" /> class.
        /// </summary>
        public UltravoxV1HttpAuthRequirement()
        {
        }
    }
}