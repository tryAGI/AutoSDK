//HintName: G.Models.PartialExpressiveAgentPresenterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Presenter type
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PartialExpressiveAgentPresenterType
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
    public static class PartialExpressiveAgentPresenterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialExpressiveAgentPresenterType value)
        {
            return value switch
            {
                PartialExpressiveAgentPresenterType.Expressive => "expressive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialExpressiveAgentPresenterType? ToEnum(string value)
        {
            return value switch
            {
                "expressive" => PartialExpressiveAgentPresenterType.Expressive,
                _ => null,
            };
        }
    }
}