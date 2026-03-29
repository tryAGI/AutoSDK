//HintName: G.Models.CreateVectordbPartitionsListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbPartitionsListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public int Code { get; set; } = default!;

        /// <summary>
        /// A list of partition names
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbPartitionsListResponse" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="data">
        /// A list of partition names
        /// </param>
        public CreateVectordbPartitionsListResponse(
            int code,
            global::System.Collections.Generic.IList<string> data)
        {
            this.Code = code;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbPartitionsListResponse" /> class.
        /// </summary>
        public CreateVectordbPartitionsListResponse()
        {
        }
    }
}