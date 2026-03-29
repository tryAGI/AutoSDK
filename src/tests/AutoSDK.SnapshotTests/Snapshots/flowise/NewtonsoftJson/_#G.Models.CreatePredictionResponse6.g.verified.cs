//HintName: G.Models.CreatePredictionResponse6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePredictionResponse6
    {
        /// <summary>
        /// Example: Validation failed. Check parameter requirements and data types.
        /// </summary>
        /// <example>Validation failed. Check parameter requirements and data types.</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse6" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Validation failed. Check parameter requirements and data types.
        /// </param>
        public CreatePredictionResponse6(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse6" /> class.
        /// </summary>
        public CreatePredictionResponse6()
        {
        }
    }
}