//HintName: G.Models.CreateSpansBulk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpansBulk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Span> Spans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpansBulk" /> class.
        /// </summary>
        /// <param name="spans"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpansBulk(
            global::System.Collections.Generic.IList<global::G.Span> spans)
        {
            this.Spans = spans ?? throw new global::System.ArgumentNullException(nameof(spans));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpansBulk" /> class.
        /// </summary>
        public CreateSpansBulk()
        {
        }
    }
}