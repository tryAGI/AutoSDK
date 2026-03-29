//HintName: G.Models.OutputItemFunctionCallStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputItemFunctionCallStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemFunctionCallStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemFunctionCallStatus2 value)
        {
            return value switch
            {
                OutputItemFunctionCallStatus2.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemFunctionCallStatus2? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => OutputItemFunctionCallStatus2.InProgress,
                _ => null,
            };
        }
    }
}