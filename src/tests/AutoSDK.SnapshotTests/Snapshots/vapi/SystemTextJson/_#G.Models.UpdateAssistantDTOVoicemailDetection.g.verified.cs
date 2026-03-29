//HintName: G.Models.UpdateAssistantDTOVoicemailDetection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAssistantDTOVoicemailDetection
    {
        /// <summary>
        /// 
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAssistantDTOVoicemailDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssistantDTOVoicemailDetection value)
        {
            return value switch
            {
                UpdateAssistantDTOVoicemailDetection.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssistantDTOVoicemailDetection? ToEnum(string value)
        {
            return value switch
            {
                "off" => UpdateAssistantDTOVoicemailDetection.Off,
                _ => null,
            };
        }
    }
}