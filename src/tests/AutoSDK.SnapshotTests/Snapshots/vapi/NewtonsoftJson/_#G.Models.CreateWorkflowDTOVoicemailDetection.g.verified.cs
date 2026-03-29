//HintName: G.Models.CreateWorkflowDTOVoicemailDetection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateWorkflowDTOVoicemailDetection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWorkflowDTOVoicemailDetectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWorkflowDTOVoicemailDetection value)
        {
            return value switch
            {
                CreateWorkflowDTOVoicemailDetection.Off => "off",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWorkflowDTOVoicemailDetection? ToEnum(string value)
        {
            return value switch
            {
                "off" => CreateWorkflowDTOVoicemailDetection.Off,
                _ => null,
            };
        }
    }
}