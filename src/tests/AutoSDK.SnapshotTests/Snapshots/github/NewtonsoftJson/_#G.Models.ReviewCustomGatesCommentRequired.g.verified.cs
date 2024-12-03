//HintName: G.Models.ReviewCustomGatesCommentRequired.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReviewCustomGatesCommentRequired
    {
        /// <summary>
        /// The name of the environment to approve or reject.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string EnvironmentName { get; set; } = default!;

        /// <summary>
        /// Comment associated with the pending deployment protection rule. **Required when state is not provided.**
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment", Required = global::Newtonsoft.Json.Required.Always)]
        public string Comment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewCustomGatesCommentRequired" /> class.
        /// </summary>
        /// <param name="environmentName">
        /// The name of the environment to approve or reject.
        /// </param>
        /// <param name="comment">
        /// Comment associated with the pending deployment protection rule. **Required when state is not provided.**
        /// </param>
        public ReviewCustomGatesCommentRequired(
            string environmentName,
            string comment)
        {
            this.EnvironmentName = environmentName ?? throw new global::System.ArgumentNullException(nameof(environmentName));
            this.Comment = comment ?? throw new global::System.ArgumentNullException(nameof(comment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewCustomGatesCommentRequired" /> class.
        /// </summary>
        public ReviewCustomGatesCommentRequired()
        {
        }
    }
}