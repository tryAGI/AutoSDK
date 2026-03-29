//HintName: G.Models.CreateMetricRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMetricRequest
    {
        /// <summary>
        /// The name of the metric. This must be a unique name that only allows lower case letters, numbers, and the characters _, -, and .
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The display name of the metric.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The prompt associated with the metric, detailing the task and evaluation criteria.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMetricRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the metric. This must be a unique name that only allows lower case letters, numbers, and the characters _, -, and .
        /// </param>
        /// <param name="prompt">
        /// The prompt associated with the metric, detailing the task and evaluation criteria.
        /// </param>
        /// <param name="displayName">
        /// The display name of the metric.
        /// </param>
        public CreateMetricRequest(
            string name,
            string prompt,
            string? displayName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMetricRequest" /> class.
        /// </summary>
        public CreateMetricRequest()
        {
        }
    }
}