//HintName: G.Models.LseProjectParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseProjectParams
    {
        /// <summary>
        /// user ID and user weight in score calculation. Format {user_id[int]: weight[Float[0..1]]}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotator_params")]
        public object? AnnotatorParams { get; set; }

        /// <summary>
        /// If categorical variables are used in labeling (e.g. choices), Cohen's Kappa statistic is computed to measure inter-rater reliability instead of basic agreement
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_kappa")]
        public bool? UseKappa { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseProjectParams" /> class.
        /// </summary>
        /// <param name="annotatorParams">
        /// user ID and user weight in score calculation. Format {user_id[int]: weight[Float[0..1]]}
        /// </param>
        /// <param name="useKappa">
        /// If categorical variables are used in labeling (e.g. choices), Cohen's Kappa statistic is computed to measure inter-rater reliability instead of basic agreement
        /// </param>
        public LseProjectParams(
            object? annotatorParams,
            bool? useKappa)
        {
            this.AnnotatorParams = annotatorParams;
            this.UseKappa = useKappa;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseProjectParams" /> class.
        /// </summary>
        public LseProjectParams()
        {
        }
    }
}