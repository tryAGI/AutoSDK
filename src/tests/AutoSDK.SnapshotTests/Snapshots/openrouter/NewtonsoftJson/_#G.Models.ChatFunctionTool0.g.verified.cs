//HintName: G.Models.ChatFunctionTool0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatFunctionTool0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatFunctionToolOneOf0Type Type { get; set; }

        /// <summary>
        /// Function definition for tool calling
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatFunctionToolOneOf0Function Function { get; set; } = default!;

        /// <summary>
        /// Cache control for the content part
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.ChatContentCacheControl? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFunctionTool0" /> class.
        /// </summary>
        /// <param name="function">
        /// Function definition for tool calling
        /// </param>
        /// <param name="type"></param>
        /// <param name="cacheControl">
        /// Cache control for the content part
        /// </param>
        public ChatFunctionTool0(
            global::G.ChatFunctionToolOneOf0Function function,
            global::G.ChatFunctionToolOneOf0Type type,
            global::G.ChatContentCacheControl? cacheControl)
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatFunctionTool0" /> class.
        /// </summary>
        public ChatFunctionTool0()
        {
        }
    }
}