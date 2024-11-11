//HintName: G.Models.FinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        public int? Length { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence")]
        public string? Sequence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinishReason" /> class.
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="length"></param>
        /// <param name="sequence"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FinishReason(
            string reason,
            int? length,
            string? sequence)
        {
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Length = length;
            this.Sequence = sequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinishReason" /> class.
        /// </summary>
        public FinishReason()
        {
        }
    }
}