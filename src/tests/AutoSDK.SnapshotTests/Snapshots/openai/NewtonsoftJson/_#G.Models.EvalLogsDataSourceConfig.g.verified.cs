//HintName: G.Models.EvalLogsDataSourceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A LogsDataSourceConfig which specifies the metadata property of your logs query.<br/>
    /// This is usually metadata like `usecase=chatbot` or `prompt-version=v2`, etc.<br/>
    /// The schema returned by this data source config is used to defined what variables are available in your evals.<br/>
    /// `item` and `sample` are both defined when using this data source config.
    /// </summary>
    public sealed partial class EvalLogsDataSourceConfig
    {
        /// <summary>
        /// The type of data source. Always `logs`.<br/>
        /// Default Value: logs
        /// </summary>
        /// <default>global::G.EvalLogsDataSourceConfigType.Logs</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.EvalLogsDataSourceConfigType Type { get; set; } = global::G.EvalLogsDataSourceConfigType.Logs;

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The json schema for the run data source items.<br/>
        /// Learn how to build JSON schemas [here](https://json-schema.org/).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object Schema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalLogsDataSourceConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of data source. Always `logs`.<br/>
        /// Default Value: logs
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="schema">
        /// The json schema for the run data source items.<br/>
        /// Learn how to build JSON schemas [here](https://json-schema.org/).
        /// </param>
        public EvalLogsDataSourceConfig(
            object schema,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::G.EvalLogsDataSourceConfigType type = global::G.EvalLogsDataSourceConfigType.Logs)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Type = type;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalLogsDataSourceConfig" /> class.
        /// </summary>
        public EvalLogsDataSourceConfig()
        {
        }
    }
}