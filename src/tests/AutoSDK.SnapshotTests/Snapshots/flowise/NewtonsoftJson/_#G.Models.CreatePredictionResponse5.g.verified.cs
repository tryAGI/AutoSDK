//HintName: G.Models.CreatePredictionResponse5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePredictionResponse5
    {
        /// <summary>
        /// Example: Request payload too large. Please reduce file sizes or split large requests.
        /// </summary>
        /// <example>Request payload too large. Please reduce file sizes or split large requests.</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse5" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Request payload too large. Please reduce file sizes or split large requests.
        /// </param>
        public CreatePredictionResponse5(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePredictionResponse5" /> class.
        /// </summary>
        public CreatePredictionResponse5()
        {
        }
    }
}