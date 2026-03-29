//HintName: G.Models.CreatePredictionResponse7.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePredictionResponse7
    {
        /// <summary>
        /// Example: Internal server error. Check flow configuration and node settings.
        /// </summary>
        /// <example>Internal server error. Check flow configuration and node settings.</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse7" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Internal server error. Check flow configuration and node settings.
        /// </param>
        public CreatePredictionResponse7(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse7" /> class.
        /// </summary>
        public CreatePredictionResponse7()
        {
        }
    }
}