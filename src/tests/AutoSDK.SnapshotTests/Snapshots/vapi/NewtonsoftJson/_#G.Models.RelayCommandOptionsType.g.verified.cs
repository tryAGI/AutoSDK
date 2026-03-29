//HintName: G.Models.RelayCommandOptionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RelayCommandOptionsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message.add")]
        MessageAdd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="say")]
        Say,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RelayCommandOptionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RelayCommandOptionsType value)
        {
            return value switch
            {
                RelayCommandOptionsType.MessageAdd => "message.add",
                RelayCommandOptionsType.Say => "say",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RelayCommandOptionsType? ToEnum(string value)
        {
            return value switch
            {
                "message.add" => RelayCommandOptionsType.MessageAdd,
                "say" => RelayCommandOptionsType.Say,
                _ => null,
            };
        }
    }
}