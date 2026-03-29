//HintName: G.Models.TemplatesCreateAgentsFromTemplateNoProjectResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesCreateAgentsFromTemplateNoProjectResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateAgentsFromTemplateNoProjectResponse2" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="limit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesCreateAgentsFromTemplateNoProjectResponse2(
            string message,
            double limit)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateAgentsFromTemplateNoProjectResponse2" /> class.
        /// </summary>
        public TemplatesCreateAgentsFromTemplateNoProjectResponse2()
        {
        }
    }
}