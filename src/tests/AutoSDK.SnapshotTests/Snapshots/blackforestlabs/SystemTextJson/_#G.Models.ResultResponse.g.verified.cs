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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StatusResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StatusResponse Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public object? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public object? Preview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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