//HintName: G.Models.ReadFineTuningResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReadFineTuningResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.ReadFineTuningResponseData? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadFineTuningResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="id"></param>
        /// <param name="object"></param>
        public ReadFineTuningResponse(
            global::G.ReadFineTuningResponseData? data,
            string? id,
            string? @object)
        {
            this.Data = data;
            this.Id = id;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadFineTuningResponse" /> class.
        /// </summary>
        public ReadFineTuningResponse()
        {
        }
    }
}