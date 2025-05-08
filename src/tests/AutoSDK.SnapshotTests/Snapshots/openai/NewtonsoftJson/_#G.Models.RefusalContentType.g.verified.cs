//HintName: G.Models.RefusalContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the refusal. Always `refusal`.<br/>
    /// Default Value: refusal
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RefusalContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="refusal")]
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RefusalContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RefusalContentType value)
        {
            return value switch
            {
                RefusalContentType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RefusalContentType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => RefusalContentType.Refusal,
                _ => null,
            };
        }
    }
}