//HintName: G.Models.ChunkedOutputJsonNodePublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChunkedOutputJsonNodePublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::G.ChunkedOutputJsonNodePublicType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed")]
        public bool? Closed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkedOutputJsonNodePublic" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="closed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChunkedOutputJsonNodePublic(
            global::G.ChunkedOutputJsonNodePublicType? type,
            bool? closed)
        {
            this.Type = type;
            this.Closed = closed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkedOutputJsonNodePublic" /> class.
        /// </summary>
        public ChunkedOutputJsonNodePublic()
        {
        }
    }
}