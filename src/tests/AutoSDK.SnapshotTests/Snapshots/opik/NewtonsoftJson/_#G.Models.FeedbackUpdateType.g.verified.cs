//HintName: G.Models.FeedbackUpdateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FeedbackUpdateType
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
    public static class FeedbackUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackUpdateType value)
        {
            return value switch
            {
                FeedbackUpdateType.Boolean => "boolean",
                FeedbackUpdateType.Categorical => "categorical",
                FeedbackUpdateType.Numerical => "numerical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FeedbackUpdateType.Boolean,
                "categorical" => FeedbackUpdateType.Categorical,
                "numerical" => FeedbackUpdateType.Numerical,
                _ => null,
            };
        }
    }
}