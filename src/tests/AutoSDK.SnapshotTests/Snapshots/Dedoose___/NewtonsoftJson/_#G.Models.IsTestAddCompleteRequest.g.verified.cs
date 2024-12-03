//HintName: G.Models.IsTestAddCompleteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IsTestAddCompleteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("addTestWorkerId", Required = global::Newtonsoft.Json.Required.Always)]
        public string AddTestWorkerId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IsTestAddCompleteRequest" /> class.
        /// </summary>
        /// <param name="addTestWorkerId"></param>
        public IsTestAddCompleteRequest(
            string addTestWorkerId)
        {
            this.AddTestWorkerId = addTestWorkerId ?? throw new global::System.ArgumentNullException(nameof(addTestWorkerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IsTestAddCompleteRequest" /> class.
        /// </summary>
        public IsTestAddCompleteRequest()
        {
        }
    }
}