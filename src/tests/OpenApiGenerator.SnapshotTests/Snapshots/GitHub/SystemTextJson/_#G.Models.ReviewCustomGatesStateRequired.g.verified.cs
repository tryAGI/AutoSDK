//HintName: G.Models.ReviewCustomGatesStateRequired.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReviewCustomGatesStateRequired
    {
        /// <summary>
        /// The name of the environment to approve or reject.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentName { get; set; }

        /// <summary>
        /// Whether to approve or reject deployment to the specified environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReviewCustomGatesStateRequiredStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required ReviewCustomGatesStateRequiredState State { get; set; }

        /// <summary>
        /// Optional comment to include with the review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}