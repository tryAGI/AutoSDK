//HintName: G.Models.OnboardingInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OnboardingInfo
    {
        /// <summary>
        /// 是否显示所有建议问题
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_all_suggestions")]
        public bool? DisplayAllSuggestions { get; set; }

        /// <summary>
        /// markdown 格式
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prologue")]
        public string? Prologue { get; set; }

        /// <summary>
        /// 问题列表
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suggested_questions")]
        public global::System.Collections.Generic.IList<string>? SuggestedQuestions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingInfo" /> class.
        /// </summary>
        /// <param name="displayAllSuggestions">
        /// 是否显示所有建议问题
        /// </param>
        /// <param name="prologue">
        /// markdown 格式
        /// </param>
        /// <param name="suggestedQuestions">
        /// 问题列表
        /// </param>
        public OnboardingInfo(
            bool? displayAllSuggestions,
            string? prologue,
            global::System.Collections.Generic.IList<string>? suggestedQuestions)
        {
            this.DisplayAllSuggestions = displayAllSuggestions;
            this.Prologue = prologue;
            this.SuggestedQuestions = suggestedQuestions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingInfo" /> class.
        /// </summary>
        public OnboardingInfo()
        {
        }
    }
}