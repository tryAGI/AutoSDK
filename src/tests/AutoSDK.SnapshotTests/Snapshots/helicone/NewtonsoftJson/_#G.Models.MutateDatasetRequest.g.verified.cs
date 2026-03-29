//HintName: G.Models.MutateDatasetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MutateDatasetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("removeRequests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> RemoveRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("addRequests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AddRequests { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MutateDatasetRequest" /> class.
        /// </summary>
        /// <param name="removeRequests"></param>
        /// <param name="addRequests"></param>
        public MutateDatasetRequest(
            global::System.Collections.Generic.IList<string> removeRequests,
            global::System.Collections.Generic.IList<string> addRequests)
        {
            this.RemoveRequests = removeRequests ?? throw new global::System.ArgumentNullException(nameof(removeRequests));
            this.AddRequests = addRequests ?? throw new global::System.ArgumentNullException(nameof(addRequests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MutateDatasetRequest" /> class.
        /// </summary>
        public MutateDatasetRequest()
        {
        }
    }
}