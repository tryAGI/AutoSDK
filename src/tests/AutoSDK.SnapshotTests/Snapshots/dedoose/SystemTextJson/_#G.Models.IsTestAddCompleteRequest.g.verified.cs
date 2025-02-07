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
        [global::System.Text.Json.Serialization.JsonPropertyName("addTestWorkerId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AddTestWorkerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IsTestAddCompleteRequest" /> class.
        /// </summary>
        /// <param name="addTestWorkerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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