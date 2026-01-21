//HintName: G.Models.ResponseBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseBase
    {
        /// <summary>
        /// Example: cmpl-e5cc70bb28c444948073e77776eb30ef
        /// </summary>
        /// <example>cmpl-e5cc70bb28c444948073e77776eb30ef</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: chat.completion
        /// </summary>
        /// <example>chat.completion</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Example: mistral-small-latest
        /// </summary>
        /// <example>mistral-small-latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.UsageInfo? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseBase" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: cmpl-e5cc70bb28c444948073e77776eb30ef
        /// </param>
        /// <param name="object">
        /// Example: chat.completion
        /// </param>
        /// <param name="model">
        /// Example: mistral-small-latest
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseBase(
            string? id,
            string? @object,
            string? model,
            global::G.UsageInfo? usage)
        {
            this.Id = id;
            this.Object = @object;
            this.Model = model;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseBase" /> class.
        /// </summary>
        public ResponseBase()
        {
        }
    }
}