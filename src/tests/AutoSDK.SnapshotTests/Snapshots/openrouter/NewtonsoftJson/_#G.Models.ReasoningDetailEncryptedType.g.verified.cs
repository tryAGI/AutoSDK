//HintName: G.Models.ReasoningDetailEncryptedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReasoningDetailEncryptedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reasoning.encrypted")]
        ReasoningEncrypted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningDetailEncryptedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningDetailEncryptedType value)
        {
            return value switch
            {
                ReasoningDetailEncryptedType.ReasoningEncrypted => "reasoning.encrypted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningDetailEncryptedType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning.encrypted" => ReasoningDetailEncryptedType.ReasoningEncrypted,
                _ => null,
            };
        }
    }
}