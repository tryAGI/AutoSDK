//HintName: G.Models.ExpiredResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: expired
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpiredResultType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expired")]
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExpiredResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpiredResultType value)
        {
            return value switch
            {
                ExpiredResultType.Expired => "expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpiredResultType? ToEnum(string value)
        {
            return value switch
            {
                "expired" => ExpiredResultType.Expired,
                _ => null,
            };
        }
    }
}