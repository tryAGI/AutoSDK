//HintName: G.Models.SmsContentInferredType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SmsContentInferredType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inferred")]
        Inferred,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsContentInferredTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsContentInferredType value)
        {
            return value switch
            {
                SmsContentInferredType.Inferred => "inferred",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsContentInferredType? ToEnum(string value)
        {
            return value switch
            {
                "inferred" => SmsContentInferredType.Inferred,
                _ => null,
            };
        }
    }
}