//HintName: G.Models.UpdatePromptPartialRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePromptPartialRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("string")]
        public string? String { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePromptPartialRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="string"></param>
        /// <param name="description"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePromptPartialRequest(
            string? name,
            string? @string,
            string? description,
            string? status)
        {
            this.Name = name;
            this.String = @string;
            this.Description = description;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePromptPartialRequest" /> class.
        /// </summary>
        public UpdatePromptPartialRequest()
        {
        }
    }
}