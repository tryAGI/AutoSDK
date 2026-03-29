//HintName: G.Models.TransferDestinationSipType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransferDestinationSipType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sip")]
        Sip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferDestinationSipTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferDestinationSipType value)
        {
            return value switch
            {
                TransferDestinationSipType.Sip => "sip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferDestinationSipType? ToEnum(string value)
        {
            return value switch
            {
                "sip" => TransferDestinationSipType.Sip,
                _ => null,
            };
        }
    }
}