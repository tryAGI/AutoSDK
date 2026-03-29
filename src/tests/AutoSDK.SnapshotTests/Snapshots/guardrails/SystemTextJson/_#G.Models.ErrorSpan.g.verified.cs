//HintName: G.Models.ErrorSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A span marking an error in the validated text.
    /// </summary>
    public sealed partial class ErrorSpan
    {
        /// <summary>
        /// The start index of the error span.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// The end index of the error span.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// The reason validation failed, specific to this chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorSpan" /> class.
        /// </summary>
        /// <param name="start">
        /// The start index of the error span.
        /// </param>
        /// <param name="end">
        /// The end index of the error span.
        /// </param>
        /// <param name="reason">
        /// The reason validation failed, specific to this chunk.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorSpan(
            int start,
            int end,
            string reason)
        {
            this.Start = start;
            this.End = end;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorSpan" /> class.
        /// </summary>
        public ErrorSpan()
        {
        }
    }
}