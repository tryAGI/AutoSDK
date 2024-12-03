//HintName: G.Models.ConfiguredBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredBy value)
        {
            return value switch
            {
                ConfiguredBy.System => "system",
                ConfiguredBy.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredBy? ToEnum(string value)
        {
            return value switch
            {
                "system" => ConfiguredBy.System,
                "user" => ConfiguredBy.User,
                _ => null,
            };
        }
    }
}