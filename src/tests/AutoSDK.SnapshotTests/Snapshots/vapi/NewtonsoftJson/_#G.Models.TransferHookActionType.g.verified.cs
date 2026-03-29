//HintName: G.Models.TransferHookActionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of action - must be "transfer"
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransferHookActionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer")]
        Transfer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransferHookActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferHookActionType value)
        {
            return value switch
            {
                TransferHookActionType.Transfer => "transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferHookActionType? ToEnum(string value)
        {
            return value switch
            {
                "transfer" => TransferHookActionType.Transfer,
                _ => null,
            };
        }
    }
}