//HintName: G.Models.TransferDestinationInferredType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of transfer destination.
    /// </summary>
    public enum TransferDestinationInferredType
    {
        /// <summary>
        /// 
        /// </summary>
        Inferred,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferDestinationInferredTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferDestinationInferredType value)
        {
            return value switch
            {
                TransferDestinationInferredType.Inferred => "inferred",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferDestinationInferredType? ToEnum(string value)
        {
            return value switch
            {
                "inferred" => TransferDestinationInferredType.Inferred,
                _ => null,
            };
        }
    }
}