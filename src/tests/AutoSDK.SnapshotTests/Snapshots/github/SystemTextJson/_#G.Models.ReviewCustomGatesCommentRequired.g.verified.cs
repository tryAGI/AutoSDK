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
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentName { get; set; }

        /// <summary>
        /// Comment associated with the pending deployment protection rule. **Required when state is not provided.**
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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