//HintName: G.Models.CreateEvaluationPipelineRequestScoreConfigurationCodeLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Language of the code (defaults to PYTHON)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEvaluationPipelineRequestScoreConfigurationCodeLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="JAVASCRIPT")]
        Javascript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PYTHON")]
        Python,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvaluationPipelineRequestScoreConfigurationCodeLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvaluationPipelineRequestScoreConfigurationCodeLanguage value)
        {
            return value switch
            {
                CreateEvaluationPipelineRequestScoreConfigurationCodeLanguage.Javascript => "JAVASCRIPT",
                CreateEvaluationPipelineRequestScoreConfigurationCodeLanguage.Python => "PYTHON",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvaluationPipelineRequestScoreConfigurationCodeLanguage? ToEnum(string value)
        {
            return value switch
            {
                "JAVASCRIPT" => CreateEvaluationPipelineRequestScoreConfigurationCodeLanguage.Javascript,
                "PYTHON" => CreateEvaluationPipelineRequestScoreConfigurationCodeLanguage.Python,
                _ => null,
            };
        }
    }
}