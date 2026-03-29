//HintName: G.Models.StructuredResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredResult
    {
        /// <summary>
        /// List of structured pages or failed page entries
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnyOf<global::G.StructuredResultPage, global::G.FailedStructuredPage>> Pages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredResult" /> class.
        /// </summary>
        /// <param name="pages">
        /// List of structured pages or failed page entries
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredResult(
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.StructuredResultPage, global::G.FailedStructuredPage>> pages)
        {
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredResult" /> class.
        /// </summary>
        public StructuredResult()
        {
        }
    }
}