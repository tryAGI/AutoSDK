//HintName: G.Models.ExtractionResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of an extraction job.
    /// </summary>
    public sealed partial class ExtractionResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionResult" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="warnings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionResult(
            object data,
            global::System.Collections.Generic.IList<string> warnings)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Warnings = warnings ?? throw new global::System.ArgumentNullException(nameof(warnings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionResult" /> class.
        /// </summary>
        public ExtractionResult()
        {
        }
    }
}