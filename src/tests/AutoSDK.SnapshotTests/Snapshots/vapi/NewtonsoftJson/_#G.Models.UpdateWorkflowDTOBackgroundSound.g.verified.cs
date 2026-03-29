//HintName: G.Models.UpdateWorkflowDTOBackgroundSound.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: office
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateWorkflowDTOBackgroundSound
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="office")]
        Office,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateWorkflowDTOBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateWorkflowDTOBackgroundSound value)
        {
            return value switch
            {
                UpdateWorkflowDTOBackgroundSound.Off => "off",
                UpdateWorkflowDTOBackgroundSound.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateWorkflowDTOBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "off" => UpdateWorkflowDTOBackgroundSound.Off,
                "office" => UpdateWorkflowDTOBackgroundSound.Office,
                _ => null,
            };
        }
    }
}