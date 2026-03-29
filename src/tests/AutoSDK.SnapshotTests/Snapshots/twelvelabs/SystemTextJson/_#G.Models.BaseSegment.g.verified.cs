//HintName: G.Models.BaseSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that contains the embedding value of a segment.
    /// </summary>
    public sealed partial class BaseSegment
    {
        /// <summary>
        /// An array of floating point numbers representing the embedding. You can use this array with cosine similarity for various downstream tasks. Note that the example response was truncated for brevity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("float")]
        public global::System.Collections.Generic.IList<double>? Float { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSegment" /> class.
        /// </summary>
        /// <param name="float">
        /// An array of floating point numbers representing the embedding. You can use this array with cosine similarity for various downstream tasks. Note that the example response was truncated for brevity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseSegment(
            global::System.Collections.Generic.IList<double>? @float)
        {
            this.Float = @float;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSegment" /> class.
        /// </summary>
        public BaseSegment()
        {
        }
    }
}