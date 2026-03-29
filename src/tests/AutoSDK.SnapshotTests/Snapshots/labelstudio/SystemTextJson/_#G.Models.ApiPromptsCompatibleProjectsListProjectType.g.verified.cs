//HintName: G.Models.ApiPromptsCompatibleProjectsListProjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: TextClassification
    /// </summary>
    public enum ApiPromptsCompatibleProjectsListProjectType
    {
        /// <summary>
        /// 
        /// </summary>
        NamedEntityRecognition,
        /// <summary>
        /// 
        /// </summary>
        TextClassification,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiPromptsCompatibleProjectsListProjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiPromptsCompatibleProjectsListProjectType value)
        {
            return value switch
            {
                ApiPromptsCompatibleProjectsListProjectType.NamedEntityRecognition => "NamedEntityRecognition",
                ApiPromptsCompatibleProjectsListProjectType.TextClassification => "TextClassification",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiPromptsCompatibleProjectsListProjectType? ToEnum(string value)
        {
            return value switch
            {
                "NamedEntityRecognition" => ApiPromptsCompatibleProjectsListProjectType.NamedEntityRecognition,
                "TextClassification" => ApiPromptsCompatibleProjectsListProjectType.TextClassification,
                _ => null,
            };
        }
    }
}