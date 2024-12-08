//HintName: G.Models.PromptCachingBetaInputMessage.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptCachingBetaInputMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptCachingBetaInputMessageRole Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ContentVariant2Item3>> Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCachingBetaInputMessage" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        public PromptCachingBetaInputMessage(
            global::G.PromptCachingBetaInputMessageRole role,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.ContentVariant2Item3>> content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCachingBetaInputMessage" /> class.
        /// </summary>
        public PromptCachingBetaInputMessage()
        {
        }
    }
}