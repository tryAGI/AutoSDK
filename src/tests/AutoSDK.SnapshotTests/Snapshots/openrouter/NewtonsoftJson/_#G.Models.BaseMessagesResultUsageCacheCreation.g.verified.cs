//HintName: G.Models.BaseMessagesResultUsageCacheCreation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultUsageCacheCreation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ephemeral_5m_input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double Ephemeral5mInputTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ephemeral_1h_input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double Ephemeral1hInputTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultUsageCacheCreation" /> class.
        /// </summary>
        /// <param name="ephemeral5mInputTokens"></param>
        /// <param name="ephemeral1hInputTokens"></param>
        public BaseMessagesResultUsageCacheCreation(
            double ephemeral5mInputTokens,
            double ephemeral1hInputTokens)
        {
            this.Ephemeral5mInputTokens = ephemeral5mInputTokens;
            this.Ephemeral1hInputTokens = ephemeral1hInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultUsageCacheCreation" /> class.
        /// </summary>
        public BaseMessagesResultUsageCacheCreation()
        {
        }
    }
}