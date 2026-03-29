//HintName: G.Models.FindFeedbackDefinitionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FindFeedbackDefinitionsType
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
    public static class FindFeedbackDefinitionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FindFeedbackDefinitionsType value)
        {
            return value switch
            {
                FindFeedbackDefinitionsType.Boolean => "boolean",
                FindFeedbackDefinitionsType.Categorical => "categorical",
                FindFeedbackDefinitionsType.Numerical => "numerical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FindFeedbackDefinitionsType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FindFeedbackDefinitionsType.Boolean,
                "categorical" => FindFeedbackDefinitionsType.Categorical,
                "numerical" => FindFeedbackDefinitionsType.Numerical,
                _ => null,
            };
        }
    }
}