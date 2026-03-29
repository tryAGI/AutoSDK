//HintName: G.Models.CreatePredictionResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePredictionResponse3
    {
        /// <summary>
        /// Example: Unauthorized access. Please verify your API key.
        /// </summary>
        /// <example>Unauthorized access. Please verify your API key.</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse3" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Unauthorized access. Please verify your API key.
        /// </param>
        public CreatePredictionResponse3(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse3" /> class.
        /// </summary>
        public CreatePredictionResponse3()
        {
        }
    }
}