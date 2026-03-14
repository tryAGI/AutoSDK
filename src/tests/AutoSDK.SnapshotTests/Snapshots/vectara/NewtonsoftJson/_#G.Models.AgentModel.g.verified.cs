//HintName: G.Models.AgentModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for the model used in this step, including the model name and arbitrary parameters.
    /// </summary>
    public sealed partial class AgentModel
    {
        /// <summary>
        /// The name of the model to use for this step.<br/>
        /// Example: gpt-4
        /// </summary>
        /// <example>gpt-4</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Arbitrary model-specific parameters that can be passed to the model.<br/>
        /// Example: {"temperature":0.7,"max_tokens":1000,"top_p":0.9}
        /// </summary>
        /// <example>{"temperature":0.7,"max_tokens":1000,"top_p":0.9}</example>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Configuration for automatic retry of failed LLM requests with exponential backoff.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retry_configuration")]
        public global::G.RetryConfiguration? RetryConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentModel" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the model to use for this step.<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="parameters">
        /// Arbitrary model-specific parameters that can be passed to the model.<br/>
        /// Example: {"temperature":0.7,"max_tokens":1000,"top_p":0.9}
        /// </param>
        /// <param name="retryConfiguration">
        /// Configuration for automatic retry of failed LLM requests with exponential backoff.
        /// </param>
        public AgentModel(
            string name,
            object? parameters,
            global::G.RetryConfiguration? retryConfiguration)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Parameters = parameters;
            this.RetryConfiguration = retryConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentModel" /> class.
        /// </summary>
        public AgentModel()
        {
        }
    }
}