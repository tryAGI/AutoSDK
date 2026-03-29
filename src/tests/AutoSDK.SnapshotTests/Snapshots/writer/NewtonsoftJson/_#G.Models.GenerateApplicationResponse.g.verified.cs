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
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The response from the model specified in the application.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suggestion", Required = global::Newtonsoft.Json.Required.Always)]
        public string Suggestion { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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