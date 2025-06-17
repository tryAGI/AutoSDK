//HintName: G.Models.SystemToolConfigInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool<br/>
    /// Default Value: system
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SystemToolConfigInputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemToolConfigInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemToolConfigInputType value)
        {
            return value switch
            {
                SystemToolConfigInputType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemToolConfigInputType? ToEnum(string value)
        {
            return value switch
            {
                "system" => SystemToolConfigInputType.System,
                _ => null,
            };
        }
    }
}