//HintName: G.Models.TransferCallToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TransferCallToolType
    {
        /// <summary>
        /// 
        /// </summary>
        TransferCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferCallToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferCallToolType value)
        {
            return value switch
            {
                TransferCallToolType.TransferCall => "transfer_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferCallToolType? ToEnum(string value)
        {
            return value switch
            {
                "transfer_call" => TransferCallToolType.TransferCall,
                _ => null,
            };
        }
    }
}