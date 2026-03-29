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
        [global::Newtonsoft.Json.JsonProperty("attached_function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AttachedFunctionApiResponse AttachedFunction { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAttachedFunctionResponse" /> class.
        /// </summary>
        /// <param name="attachedFunction">
        /// API response struct for attached function with function_name instead of function_id
        /// </param>
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