//HintName: G.Models.CreateEvalRunRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalRunRequest
    {
        /// <summary>
        /// The name of the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

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
        /// Details about the run's data source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.CreateEvalJsonlRunDataSource, global::G.CreateEvalCompletionsRunDataSource, global::G.CreateEvalResponsesRunDataSource> DataSource { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalRunRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the run.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="dataSource">
        /// Details about the run's data source.
        /// </param>
        public CreateEvalRunRequest(
            global::G.OneOf<global::G.CreateEvalJsonlRunDataSource, global::G.CreateEvalCompletionsRunDataSource, global::G.CreateEvalResponsesRunDataSource> dataSource,
            string? name,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.DataSource = dataSource;
            this.Name = name;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalRunRequest" /> class.
        /// </summary>
        public CreateEvalRunRequest()
        {
        }
    }
}