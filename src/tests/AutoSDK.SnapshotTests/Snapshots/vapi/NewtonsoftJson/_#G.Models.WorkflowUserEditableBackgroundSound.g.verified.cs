//HintName: G.Models.WorkflowUserEditableBackgroundSound.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: office
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkflowUserEditableBackgroundSound
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
    public static class WorkflowUserEditableBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowUserEditableBackgroundSound value)
        {
            return value switch
            {
                WorkflowUserEditableBackgroundSound.Off => "off",
                WorkflowUserEditableBackgroundSound.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowUserEditableBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "off" => WorkflowUserEditableBackgroundSound.Off,
                "office" => WorkflowUserEditableBackgroundSound.Office,
                _ => null,
            };
        }
    }
}