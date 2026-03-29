//HintName: G.Models.ChatSDKRequestUiFooter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequestUiFooter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expressionText")]
        public string? ExpressionText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isShow")]
        public bool? IsShow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("linkvars")]
        public object? Linkvars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiFooter" /> class.
        /// </summary>
        /// <param name="expressionText"></param>
        /// <param name="isShow"></param>
        /// <param name="linkvars"></param>
        public ChatSDKRequestUiFooter(
            string? expressionText,
            bool? isShow,
            object? linkvars)
        {
            this.ExpressionText = expressionText;
            this.IsShow = isShow;
            this.Linkvars = linkvars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiFooter" /> class.
        /// </summary>
        public ChatSDKRequestUiFooter()
        {
        }
    }
}