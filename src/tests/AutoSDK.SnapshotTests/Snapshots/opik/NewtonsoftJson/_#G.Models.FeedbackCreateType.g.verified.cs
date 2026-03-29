//HintName: G.Models.FeedbackCreateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FeedbackCreateType
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
    public static class FeedbackCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackCreateType value)
        {
            return value switch
            {
                FeedbackCreateType.Boolean => "boolean",
                FeedbackCreateType.Categorical => "categorical",
                FeedbackCreateType.Numerical => "numerical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackCreateType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FeedbackCreateType.Boolean,
                "categorical" => FeedbackCreateType.Categorical,
                "numerical" => FeedbackCreateType.Numerical,
                _ => null,
            };
        }
    }
}