//HintName: G.Models.ContextEngineeringPlanNoneType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContextEngineeringPlanNoneType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContextEngineeringPlanNoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContextEngineeringPlanNoneType value)
        {
            return value switch
            {
                ContextEngineeringPlanNoneType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContextEngineeringPlanNoneType? ToEnum(string value)
        {
            return value switch
            {
                "none" => ContextEngineeringPlanNoneType.None,
                _ => null,
            };
        }
    }
}