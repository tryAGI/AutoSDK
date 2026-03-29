//HintName: G.Models.RelayCommandSayType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of relay command
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RelayCommandSayType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="say")]
        Say,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RelayCommandSayTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RelayCommandSayType value)
        {
            return value switch
            {
                RelayCommandSayType.Say => "say",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RelayCommandSayType? ToEnum(string value)
        {
            return value switch
            {
                "say" => RelayCommandSayType.Say,
                _ => null,
            };
        }
    }
}