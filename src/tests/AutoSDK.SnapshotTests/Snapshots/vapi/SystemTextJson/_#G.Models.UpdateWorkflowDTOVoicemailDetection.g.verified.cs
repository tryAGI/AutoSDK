//HintName: G.Models.UpdateWorkflowDTOVoicemailDetection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateWorkflowDTOVoicemailDetection
    {
        /// <summary>
        /// 
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateWorkflowDTOVoicemailDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateWorkflowDTOVoicemailDetection value)
        {
            return value switch
            {
                UpdateWorkflowDTOVoicemailDetection.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateWorkflowDTOVoicemailDetection? ToEnum(string value)
        {
            return value switch
            {
                "off" => UpdateWorkflowDTOVoicemailDetection.Off,
                _ => null,
            };
        }
    }
}