//HintName: G.Models.ExtractAgentCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Settings for creating an extraction agent.
    /// </summary>
    public sealed partial class ExtractAgentCreate
    {
        /// <summary>
        /// The name of the extraction schema
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The schema of the data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<object, string> DataSchema { get; set; } = default!;

        /// <summary>
        /// The configuration parameters for the extraction agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtractConfig Config { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractAgentCreate" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the extraction schema
        /// </param>
        /// <param name="dataSchema">
        /// The schema of the data.
        /// </param>
        /// <param name="config">
        /// The configuration parameters for the extraction agent.
        /// </param>
        public ExtractAgentCreate(
            string name,
            global::G.AnyOf<object, string> dataSchema,
            global::G.ExtractConfig config)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DataSchema = dataSchema;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractAgentCreate" /> class.
        /// </summary>
        public ExtractAgentCreate()
        {
        }
    }
}