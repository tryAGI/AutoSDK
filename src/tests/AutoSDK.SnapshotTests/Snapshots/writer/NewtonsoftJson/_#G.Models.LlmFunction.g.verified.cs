//HintName: G.Models.LlmFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that uses another Writer model to generate a response.
    /// </summary>
    public sealed partial class LlmFunction
    {
        /// <summary>
        /// A description of the model to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The model to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmFunction" /> class.
        /// </summary>
        /// <param name="description">
        /// A description of the model to use.
        /// </param>
        /// <param name="model">
        /// The model to use.
        /// </param>
        public LlmFunction(
            string description,
            string model)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmFunction" /> class.
        /// </summary>
        public LlmFunction()
        {
        }
    }
}