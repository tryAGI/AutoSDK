//HintName: G.Models.BetaSucceededResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: succeeded
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaSucceededResultType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="succeeded")]
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaSucceededResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSucceededResultType value)
        {
            return value switch
            {
                BetaSucceededResultType.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSucceededResultType? ToEnum(string value)
        {
            return value switch
            {
                "succeeded" => BetaSucceededResultType.Succeeded,
                _ => null,
            };
        }
    }
}