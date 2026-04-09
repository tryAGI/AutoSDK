//HintName: G.Models.ResultResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultResponse
    {
        /// <summary>
        /// Task id for retrieving result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StatusResponseJsonConverter))]
        public global::G.StatusResponse Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public object? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress")]
        public double? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public object? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview")]
        public object? Preview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Task id for retrieving result
        /// </param>
        /// <param name="status"></param>
        /// <param name="result"></param>
        /// <param name="progress"></param>
        /// <param name="details"></param>
        /// <param name="preview"></param>
        public ResultResponse(
            string id,
            global::G.StatusResponse status,
            object? result,
            double? progress,
            object? details,
            object? preview)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Result = result;
            this.Progress = progress;
            this.Details = details;
            this.Preview = preview;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultResponse" /> class.
        /// </summary>
        public ResultResponse()
        {
        }
    }
}