//HintName: G.Models.GenerateApplicationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateApplicationResponse
    {
        /// <summary>
        /// The name of the output field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The response from the model specified in the application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Suggestion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationResponse" /> class.
        /// </summary>
        /// <param name="suggestion">
        /// The response from the model specified in the application.
        /// </param>
        /// <param name="title">
        /// The name of the output field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateApplicationResponse(
            string suggestion,
            string? title)
        {
            this.Title = title;
            this.Suggestion = suggestion ?? throw new global::System.ArgumentNullException(nameof(suggestion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationResponse" /> class.
        /// </summary>
        public GenerateApplicationResponse()
        {
        }
    }
}