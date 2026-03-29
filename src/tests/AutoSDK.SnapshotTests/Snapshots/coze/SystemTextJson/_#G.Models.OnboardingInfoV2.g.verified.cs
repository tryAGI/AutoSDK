//HintName: G.Models.OnboardingInfoV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OnboardingInfoV2
    {
        /// <summary>
        /// 对应 Coze Opening Dialog开场白
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prologue")]
        public string? Prologue { get; set; }

        /// <summary>
        /// 建议问题
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggested_questions")]
        public global::System.Collections.Generic.IList<string>? SuggestedQuestions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingInfoV2" /> class.
        /// </summary>
        /// <param name="prologue">
        /// 对应 Coze Opening Dialog开场白
        /// </param>
        /// <param name="suggestedQuestions">
        /// 建议问题
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OnboardingInfoV2(
            string? prologue,
            global::System.Collections.Generic.IList<string>? suggestedQuestions)
        {
            this.Prologue = prologue;
            this.SuggestedQuestions = suggestedQuestions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingInfoV2" /> class.
        /// </summary>
        public OnboardingInfoV2()
        {
        }
    }
}