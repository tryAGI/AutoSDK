//HintName: G.Models.ExpressiveVideoBackgroundVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpressiveVideoBackgroundVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="color")]
        Color,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExpressiveVideoBackgroundVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveVideoBackgroundVariant1Type value)
        {
            return value switch
            {
                ExpressiveVideoBackgroundVariant1Type.Color => "color",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveVideoBackgroundVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "color" => ExpressiveVideoBackgroundVariant1Type.Color,
                _ => null,
            };
        }
    }
}