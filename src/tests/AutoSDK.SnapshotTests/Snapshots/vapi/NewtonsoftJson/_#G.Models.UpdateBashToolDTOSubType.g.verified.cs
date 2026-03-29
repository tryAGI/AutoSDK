//HintName: G.Models.UpdateBashToolDTOSubType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sub type of tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateBashToolDTOSubType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bash_20241022")]
        Bash20241022,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateBashToolDTOSubTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateBashToolDTOSubType value)
        {
            return value switch
            {
                UpdateBashToolDTOSubType.Bash20241022 => "bash_20241022",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateBashToolDTOSubType? ToEnum(string value)
        {
            return value switch
            {
                "bash_20241022" => UpdateBashToolDTOSubType.Bash20241022,
                _ => null,
            };
        }
    }
}