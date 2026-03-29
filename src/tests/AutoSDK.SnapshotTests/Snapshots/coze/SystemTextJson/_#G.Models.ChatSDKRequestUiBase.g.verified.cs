//HintName: G.Models.ChatSDKRequestUiBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSDKRequestUiBase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lang")]
        public string? Lang { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout")]
        public object? Layout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zIndex")]
        public double? ZIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiBase" /> class.
        /// </summary>
        /// <param name="icon"></param>
        /// <param name="lang"></param>
        /// <param name="layout"></param>
        /// <param name="zIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSDKRequestUiBase(
            string? icon,
            string? lang,
            object? layout,
            double? zIndex)
        {
            this.Icon = icon;
            this.Lang = lang;
            this.Layout = layout;
            this.ZIndex = zIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSDKRequestUiBase" /> class.
        /// </summary>
        public ChatSDKRequestUiBase()
        {
        }
    }
}