//HintName: G.Models.CreateAssistantDTOVoicemailDetection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAssistantDTOVoicemailDetection
    {
        /// <summary>
        /// 
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssistantDTOVoicemailDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantDTOVoicemailDetection value)
        {
            return value switch
            {
                CreateAssistantDTOVoicemailDetection.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantDTOVoicemailDetection? ToEnum(string value)
        {
            return value switch
            {
                "off" => CreateAssistantDTOVoicemailDetection.Off,
                _ => null,
            };
        }
    }
}