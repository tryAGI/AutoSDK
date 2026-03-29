//HintName: G.Models.DetachFunctionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetachFunctionRequest
    {
        /// <summary>
        /// Whether to delete the output collection as well when detaching the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_output")]
        public bool? DeleteOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetachFunctionRequest" /> class.
        /// </summary>
        /// <param name="deleteOutput">
        /// Whether to delete the output collection as well when detaching the function.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetachFunctionRequest(
            bool? deleteOutput)
        {
            this.DeleteOutput = deleteOutput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetachFunctionRequest" /> class.
        /// </summary>
        public DetachFunctionRequest()
        {
        }
    }
}