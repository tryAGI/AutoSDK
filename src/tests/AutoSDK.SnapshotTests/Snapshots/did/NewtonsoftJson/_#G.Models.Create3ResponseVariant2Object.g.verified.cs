//HintName: G.Models.Create3ResponseVariant2Object.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Create3ResponseVariant2Object
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="expressive")]
        Expressive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create3ResponseVariant2ObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create3ResponseVariant2Object value)
        {
            return value switch
            {
                Create3ResponseVariant2Object.Expressive => "expressive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create3ResponseVariant2Object? ToEnum(string value)
        {
            return value switch
            {
                "expressive" => Create3ResponseVariant2Object.Expressive,
                _ => null,
            };
        }
    }
}