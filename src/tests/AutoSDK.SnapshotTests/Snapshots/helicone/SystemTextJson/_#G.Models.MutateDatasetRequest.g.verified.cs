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
        [global::System.Text.Json.Serialization.JsonPropertyName("removeRequests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RemoveRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addRequests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AddRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MutateDatasetRequest" /> class.
        /// </summary>
        /// <param name="removeRequests"></param>
        /// <param name="addRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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