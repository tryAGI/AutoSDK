//HintName: G.Models.PartialResponseTableToOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialResponseTableToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_tokens")]
        public global::G.PartialNumberOperators? BodyTokens { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_model")]
        public global::G.PartialTextOperators? BodyModel { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_completion")]
        public global::G.PartialTextOperators? BodyCompletion { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.PartialNumberOperators? Status { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.PartialTextOperators? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialResponseTableToOperators" /> class.
        /// </summary>
        /// <param name="bodyTokens">
        /// Make all properties in T optional
        /// </param>
        /// <param name="bodyModel">
        /// Make all properties in T optional
        /// </param>
        /// <param name="bodyCompletion">
        /// Make all properties in T optional
        /// </param>
        /// <param name="status">
        /// Make all properties in T optional
        /// </param>
        /// <param name="model">
        /// Make all properties in T optional
        /// </param>
        public PartialResponseTableToOperators(
            global::G.PartialNumberOperators? bodyTokens,
            global::G.PartialTextOperators? bodyModel,
            global::G.PartialTextOperators? bodyCompletion,
            global::G.PartialNumberOperators? status,
            global::G.PartialTextOperators? model)
        {
            this.BodyTokens = bodyTokens;
            this.BodyModel = bodyModel;
            this.BodyCompletion = bodyCompletion;
            this.Status = status;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialResponseTableToOperators" /> class.
        /// </summary>
        public PartialResponseTableToOperators()
        {
        }
    }
}