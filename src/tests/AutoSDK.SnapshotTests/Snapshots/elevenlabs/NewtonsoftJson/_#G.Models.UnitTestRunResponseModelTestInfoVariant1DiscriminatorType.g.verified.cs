//HintName: G.Models.UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UnitTestRunResponseModelTestInfoVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="simulation")]
        Simulation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitTestRunResponseModelTestInfoVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitTestRunResponseModelTestInfoVariant1DiscriminatorType value)
        {
            return value switch
            {
                UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Llm => "llm",
                UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Simulation => "simulation",
                UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitTestRunResponseModelTestInfoVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "llm" => UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Llm,
                "simulation" => UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Simulation,
                "tool" => UnitTestRunResponseModelTestInfoVariant1DiscriminatorType.Tool,
                _ => null,
            };
        }
    }
}