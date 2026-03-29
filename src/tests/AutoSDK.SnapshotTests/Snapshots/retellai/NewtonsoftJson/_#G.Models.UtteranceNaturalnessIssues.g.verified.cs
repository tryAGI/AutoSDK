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
        [global::Newtonsoft.Json.JsonProperty("response_id", Required = global::Newtonsoft.Json.Required.Always)]
        public double ResponseId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("naturalness_issues", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.NaturalnessIssue> NaturalnessIssues { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceNaturalnessIssues" /> class.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="naturalnessIssues"></param>
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