//HintName: G.Models.Reask.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A reask request when validation fails.
    /// </summary>
    public sealed partial class Reask
    {
        /// <summary>
        /// The value that failed validation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("incorrectValue")]
        public string? IncorrectValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failResults")]
        public global::System.Collections.Generic.IList<global::G.FailResult>? FailResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Reask" /> class.
        /// </summary>
        /// <param name="incorrectValue">
        /// The value that failed validation.
        /// </param>
        /// <param name="failResults"></param>
        public Reask(
            string? incorrectValue,
            global::System.Collections.Generic.IList<global::G.FailResult>? failResults)
        {
            this.IncorrectValue = incorrectValue;
            this.FailResults = failResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reask" /> class.
        /// </summary>
        public Reask()
        {
        }
    }
}