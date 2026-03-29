//HintName: G.Models.TransferDestinationNumberType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TransferDestinationNumberType
    {
        /// <summary>
        /// 
        /// </summary>
        Number,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferDestinationNumberTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferDestinationNumberType value)
        {
            return value switch
            {
                TransferDestinationNumberType.Number => "number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferDestinationNumberType? ToEnum(string value)
        {
            return value switch
            {
                "number" => TransferDestinationNumberType.Number,
                _ => null,
            };
        }
    }
}