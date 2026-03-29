//HintName: G.Models.TransferCallNodeVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the node
    /// </summary>
    public enum TransferCallNodeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        TransferCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferCallNodeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferCallNodeVariant2Type value)
        {
            return value switch
            {
                TransferCallNodeVariant2Type.TransferCall => "transfer_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferCallNodeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "transfer_call" => TransferCallNodeVariant2Type.TransferCall,
                _ => null,
            };
        }
    }
}