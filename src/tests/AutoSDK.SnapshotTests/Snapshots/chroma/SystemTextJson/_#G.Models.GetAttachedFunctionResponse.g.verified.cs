//HintName: G.Models.GetAttachedFunctionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAttachedFunctionResponse
    {
        /// <summary>
        /// API response struct for attached function with function_name instead of function_id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attached_function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AttachedFunctionApiResponse AttachedFunction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAttachedFunctionResponse" /> class.
        /// </summary>
        /// <param name="attachedFunction">
        /// API response struct for attached function with function_name instead of function_id
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAttachedFunctionResponse(
            global::G.AttachedFunctionApiResponse attachedFunction)
        {
            this.AttachedFunction = attachedFunction ?? throw new global::System.ArgumentNullException(nameof(attachedFunction));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAttachedFunctionResponse" /> class.
        /// </summary>
        public GetAttachedFunctionResponse()
        {
        }
    }
}