//HintName: G.Models.GenerateLLMsTxtResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateLLMsTxtResponse
    {
        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// ID of the LLMs.txt generation job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateLLMsTxtResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Example: true
        /// </param>
        /// <param name="id">
        /// ID of the LLMs.txt generation job
        /// </param>
        public GenerateLLMsTxtResponse(
            bool? success,
            global::System.Guid? id)
        {
            this.Success = success;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateLLMsTxtResponse" /> class.
        /// </summary>
        public GenerateLLMsTxtResponse()
        {
        }
    }
}