//HintName: G.Models.TransferDestinationPredefinedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of transfer destination.
    /// </summary>
    public enum TransferDestinationPredefinedType
    {
        /// <summary>
        /// 
        /// </summary>
        Predefined,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferDestinationPredefinedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferDestinationPredefinedType value)
        {
            return value switch
            {
                TransferDestinationPredefinedType.Predefined => "predefined",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferDestinationPredefinedType? ToEnum(string value)
        {
            return value switch
            {
                "predefined" => TransferDestinationPredefinedType.Predefined,
                _ => null,
            };
        }
    }
}