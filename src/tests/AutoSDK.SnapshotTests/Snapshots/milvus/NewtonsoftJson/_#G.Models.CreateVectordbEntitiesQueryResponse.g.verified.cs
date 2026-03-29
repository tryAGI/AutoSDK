//HintName: G.Models.CreateVectordbEntitiesQueryResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbEntitiesQueryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public int? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<object>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbEntitiesQueryResponse" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="data"></param>
        public CreateVectordbEntitiesQueryResponse(
            int? code,
            global::System.Collections.Generic.IList<object>? data)
        {
            this.Code = code;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbEntitiesQueryResponse" /> class.
        /// </summary>
        public CreateVectordbEntitiesQueryResponse()
        {
        }
    }
}