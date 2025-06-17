//HintName: G.Models.TransferToNumberToolConfigSystemToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: transfer_to_number
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransferToNumberToolConfigSystemToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer_to_number")]
        TransferToNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferToNumberToolConfigSystemToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferToNumberToolConfigSystemToolType value)
        {
            return value switch
            {
                TransferToNumberToolConfigSystemToolType.TransferToNumber => "transfer_to_number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferToNumberToolConfigSystemToolType? ToEnum(string value)
        {
            return value switch
            {
                "transfer_to_number" => TransferToNumberToolConfigSystemToolType.TransferToNumber,
                _ => null,
            };
        }
    }
}