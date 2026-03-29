//HintName: G.Models.BearerAuthenticationPlanType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BearerAuthenticationPlanType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bearer")]
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BearerAuthenticationPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BearerAuthenticationPlanType value)
        {
            return value switch
            {
                BearerAuthenticationPlanType.Bearer => "bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BearerAuthenticationPlanType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => BearerAuthenticationPlanType.Bearer,
                _ => null,
            };
        }
    }
}