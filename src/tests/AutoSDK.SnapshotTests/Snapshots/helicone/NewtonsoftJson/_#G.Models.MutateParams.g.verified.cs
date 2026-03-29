//HintName: G.Models.MutateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MutateParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("addRequests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AddRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("removeRequests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> RemoveRequests { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MutateParams" /> class.
        /// </summary>
        /// <param name="addRequests"></param>
        /// <param name="removeRequests"></param>
        public MutateParams(
            global::System.Collections.Generic.IList<string> addRequests,
            global::System.Collections.Generic.IList<string> removeRequests)
        {
            this.AddRequests = addRequests ?? throw new global::System.ArgumentNullException(nameof(addRequests));
            this.RemoveRequests = removeRequests ?? throw new global::System.ArgumentNullException(nameof(removeRequests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MutateParams" /> class.
        /// </summary>
        public MutateParams()
        {
        }
    }
}