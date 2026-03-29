//HintName: G.Models.UtteranceNaturalnessIssues.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UtteranceNaturalnessIssues
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ResponseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("naturalness_issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.NaturalnessIssue> NaturalnessIssues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceNaturalnessIssues" /> class.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="naturalnessIssues"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UtteranceNaturalnessIssues(
            double responseId,
            global::System.Collections.Generic.IList<global::G.NaturalnessIssue> naturalnessIssues)
        {
            this.ResponseId = responseId;
            this.NaturalnessIssues = naturalnessIssues ?? throw new global::System.ArgumentNullException(nameof(naturalnessIssues));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceNaturalnessIssues" /> class.
        /// </summary>
        public UtteranceNaturalnessIssues()
        {
        }
    }
}