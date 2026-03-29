//HintName: G.Models.PreviewWebSearchUserLocationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PreviewWebSearchUserLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="approximate")]
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreviewWebSearchUserLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreviewWebSearchUserLocationType value)
        {
            return value switch
            {
                PreviewWebSearchUserLocationType.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreviewWebSearchUserLocationType? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => PreviewWebSearchUserLocationType.Approximate,
                _ => null,
            };
        }
    }
}