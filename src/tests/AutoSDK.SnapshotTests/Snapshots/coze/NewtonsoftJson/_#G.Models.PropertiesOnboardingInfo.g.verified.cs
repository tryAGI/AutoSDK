//HintName: G.Models.PropertiesOnboardingInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PropertiesOnboardingInfo
    {
        /// <summary>
        /// 开场白
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prologue")]
        public string? Prologue { get; set; }

        /// <summary>
        /// 建议问题
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suggested_questions")]
        public global::System.Collections.Generic.IList<string>? SuggestedQuestions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesOnboardingInfo" /> class.
        /// </summary>
        /// <param name="prologue">
        /// 开场白
        /// </param>
        /// <param name="suggestedQuestions">
        /// 建议问题
        /// </param>
        public PropertiesOnboardingInfo(
            string? prologue,
            global::System.Collections.Generic.IList<string>? suggestedQuestions)
        {
            this.Prologue = prologue;
            this.SuggestedQuestions = suggestedQuestions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesOnboardingInfo" /> class.
        /// </summary>
        public PropertiesOnboardingInfo()
        {
        }
    }
}