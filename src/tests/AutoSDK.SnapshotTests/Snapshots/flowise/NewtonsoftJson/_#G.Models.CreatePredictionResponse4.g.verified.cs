//HintName: G.Models.CreatePredictionResponse4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePredictionResponse4
    {
        /// <summary>
        /// Example: Chatflow not found. Please verify the chatflow ID.
        /// </summary>
        /// <example>Chatflow not found. Please verify the chatflow ID.</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse4" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Chatflow not found. Please verify the chatflow ID.
        /// </param>
        public CreatePredictionResponse4(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse4" /> class.
        /// </summary>
        public CreatePredictionResponse4()
        {
        }
    }
}