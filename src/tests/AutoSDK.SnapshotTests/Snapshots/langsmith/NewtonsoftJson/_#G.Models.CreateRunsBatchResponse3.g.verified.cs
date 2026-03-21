//HintName: G.Models.CreateRunsBatchResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRunsBatchResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRunsBatchResponse3" /> class.
        /// </summary>
        /// <param name="message"></param>
        public CreateRunsBatchResponse3(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRunsBatchResponse3" /> class.
        /// </summary>
        public CreateRunsBatchResponse3()
        {
        }
    }
}