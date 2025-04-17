//HintName: G.Models.BatchJobIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchJobIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiEndpoint Endpoint { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> InputFiles { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Default Value: 24
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout_hours")]
        public int? TimeoutHours { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobIn" /> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="inputFiles"></param>
        /// <param name="metadata"></param>
        /// <param name="model"></param>
        /// <param name="timeoutHours">
        /// Default Value: 24
        /// </param>
        public BatchJobIn(
            global::G.ApiEndpoint endpoint,
            global::System.Collections.Generic.IList<global::System.Guid> inputFiles,
            string model,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            int? timeoutHours)
        {
            this.Endpoint = endpoint;
            this.InputFiles = inputFiles ?? throw new global::System.ArgumentNullException(nameof(inputFiles));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Metadata = metadata;
            this.TimeoutHours = timeoutHours;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchJobIn" /> class.
        /// </summary>
        public BatchJobIn()
        {
        }
    }
}