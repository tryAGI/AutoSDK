//HintName: G.Models.CreateWorkflowDTOBackgroundSound.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: office
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateWorkflowDTOBackgroundSound
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
    public static class CreateWorkflowDTOBackgroundSoundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWorkflowDTOBackgroundSound value)
        {
            return value switch
            {
                CreateWorkflowDTOBackgroundSound.Off => "off",
                CreateWorkflowDTOBackgroundSound.Office => "office",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWorkflowDTOBackgroundSound? ToEnum(string value)
        {
            return value switch
            {
                "off" => CreateWorkflowDTOBackgroundSound.Off,
                "office" => CreateWorkflowDTOBackgroundSound.Office,
                _ => null,
            };
        }
    }
}