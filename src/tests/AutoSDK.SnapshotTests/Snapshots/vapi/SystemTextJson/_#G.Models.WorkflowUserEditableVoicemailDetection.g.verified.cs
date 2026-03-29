//HintName: G.Models.WorkflowUserEditableVoicemailDetection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowUserEditableVoicemailDetection
    {
        /// <summary>
        /// 
        /// </summary>
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowUserEditableVoicemailDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowUserEditableVoicemailDetection value)
        {
            return value switch
            {
                WorkflowUserEditableVoicemailDetection.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowUserEditableVoicemailDetection? ToEnum(string value)
        {
            return value switch
            {
                "off" => WorkflowUserEditableVoicemailDetection.Off,
                _ => null,
            };
        }
    }
}