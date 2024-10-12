//HintName: G.Models.AppFeedbackSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Feedback from the LangChainPlus App.
    /// </summary>
    public sealed partial class AppFeedbackSource
    {
        /// <summary>
        /// Default Value: app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; } = "app";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}