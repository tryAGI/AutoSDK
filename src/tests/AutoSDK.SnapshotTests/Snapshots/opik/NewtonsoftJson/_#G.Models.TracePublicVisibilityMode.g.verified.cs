//HintName: G.Models.TracePublicVisibilityMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TracePublicVisibilityMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hidden")]
        Hidden,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TracePublicVisibilityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TracePublicVisibilityMode value)
        {
            return value switch
            {
                TracePublicVisibilityMode.Default => "default",
                TracePublicVisibilityMode.Hidden => "hidden",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TracePublicVisibilityMode? ToEnum(string value)
        {
            return value switch
            {
                "default" => TracePublicVisibilityMode.Default,
                "hidden" => TracePublicVisibilityMode.Hidden,
                _ => null,
            };
        }
    }
}