//HintName: G.Models.ResponseResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseResult
    {
        /// <summary>
        /// The date of the usage data in ISO-8601 format (YYYY-MM-DD). All dates are in UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// The credits used per model for the given date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedCredits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ResponseResultUsedCredit> UsedCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseResult" /> class.
        /// </summary>
        /// <param name="date">
        /// The date of the usage data in ISO-8601 format (YYYY-MM-DD). All dates are in UTC.
        /// </param>
        /// <param name="usedCredits">
        /// The credits used per model for the given date.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseResult(
            global::System.DateTime date,
            global::System.Collections.Generic.IList<global::G.ResponseResultUsedCredit> usedCredits)
        {
            this.Date = date;
            this.UsedCredits = usedCredits ?? throw new global::System.ArgumentNullException(nameof(usedCredits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseResult" /> class.
        /// </summary>
        public ResponseResult()
        {
        }
    }
}