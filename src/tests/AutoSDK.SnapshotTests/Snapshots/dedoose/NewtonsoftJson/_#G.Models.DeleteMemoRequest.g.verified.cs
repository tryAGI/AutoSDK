//HintName: G.Models.DeleteMemoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteMemoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Memo Memo { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMemoRequest" /> class.
        /// </summary>
        /// <param name="memo"></param>
        public DeleteMemoRequest(
            global::G.Memo memo)
        {
            this.Memo = memo ?? throw new global::System.ArgumentNullException(nameof(memo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMemoRequest" /> class.
        /// </summary>
        public DeleteMemoRequest()
        {
        }
    }
}