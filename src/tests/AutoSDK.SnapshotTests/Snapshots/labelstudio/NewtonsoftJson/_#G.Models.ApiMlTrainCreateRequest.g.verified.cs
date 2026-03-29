//HintName: G.Models.ApiMlTrainCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiMlTrainCreateRequest
    {
        /// <summary>
        /// Whether to include ground truth annotations in training
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_ground_truth")]
        public bool? UseGroundTruth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMlTrainCreateRequest" /> class.
        /// </summary>
        /// <param name="useGroundTruth">
        /// Whether to include ground truth annotations in training
        /// </param>
        public ApiMlTrainCreateRequest(
            bool? useGroundTruth)
        {
            this.UseGroundTruth = useGroundTruth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMlTrainCreateRequest" /> class.
        /// </summary>
        public ApiMlTrainCreateRequest()
        {
        }
    }
}