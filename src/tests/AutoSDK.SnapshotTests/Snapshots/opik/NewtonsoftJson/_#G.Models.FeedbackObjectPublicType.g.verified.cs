//HintName: G.Models.FeedbackObjectPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FeedbackObjectPublicType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="boolean")]
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="categorical")]
        Categorical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="numerical")]
        Numerical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackObjectPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackObjectPublicType value)
        {
            return value switch
            {
                FeedbackObjectPublicType.Boolean => "boolean",
                FeedbackObjectPublicType.Categorical => "categorical",
                FeedbackObjectPublicType.Numerical => "numerical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackObjectPublicType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FeedbackObjectPublicType.Boolean,
                "categorical" => FeedbackObjectPublicType.Categorical,
                "numerical" => FeedbackObjectPublicType.Numerical,
                _ => null,
            };
        }
    }
}