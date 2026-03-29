//HintName: G.Models.ExperimentDatasetRowInputRecord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentDatasetRowInputRecord
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RequestObj Request { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseObj Response { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoInputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>> AutoInputs { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Inputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestPath", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestPath { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestId", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentDatasetRowInputRecord" /> class.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="response"></param>
        /// <param name="autoInputs"></param>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="requestPath"></param>
        /// <param name="requestId"></param>
        /// <param name="id"></param>
        public ExperimentDatasetRowInputRecord(
            global::G.RequestObj request,
            global::G.ResponseObj response,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>> autoInputs,
            global::System.Collections.Generic.Dictionary<string, string> inputs,
            string requestPath,
            string requestId,
            string id)
        {
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.AutoInputs = autoInputs ?? throw new global::System.ArgumentNullException(nameof(autoInputs));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.RequestPath = requestPath ?? throw new global::System.ArgumentNullException(nameof(requestPath));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentDatasetRowInputRecord" /> class.
        /// </summary>
        public ExperimentDatasetRowInputRecord()
        {
        }
    }
}