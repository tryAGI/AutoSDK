//HintName: G.Models.TransferPhoneNumberHookActionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of action - must be "transfer"
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransferPhoneNumberHookActionType
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
    public static class TransferPhoneNumberHookActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransferPhoneNumberHookActionType value)
        {
            return value switch
            {
                TransferPhoneNumberHookActionType.Transfer => "transfer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransferPhoneNumberHookActionType? ToEnum(string value)
        {
            return value switch
            {
                "transfer" => TransferPhoneNumberHookActionType.Transfer,
                _ => null,
            };
        }
    }
}