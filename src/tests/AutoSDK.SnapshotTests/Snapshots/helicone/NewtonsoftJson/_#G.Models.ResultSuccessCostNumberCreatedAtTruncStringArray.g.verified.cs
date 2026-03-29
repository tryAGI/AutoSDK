//HintName: G.Models.ResultSuccessCostNumberCreatedAtTruncStringArray.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessCostNumberCreatedAtTruncStringArray
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem> Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public double? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessCostNumberCreatedAtTruncStringArray" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="error"></param>
        public ResultSuccessCostNumberCreatedAtTruncStringArray(
            global::System.Collections.Generic.IList<global::G.ResultSuccessCostNumberCreatedAtTruncStringArrayDataItem> data,
            double? error)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessCostNumberCreatedAtTruncStringArray" /> class.
        /// </summary>
        public ResultSuccessCostNumberCreatedAtTruncStringArray()
        {
        }
    }
}