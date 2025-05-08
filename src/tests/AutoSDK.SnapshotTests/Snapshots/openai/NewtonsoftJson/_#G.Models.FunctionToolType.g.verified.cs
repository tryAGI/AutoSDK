//HintName: G.Models.FunctionToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the function tool. Always `function`.<br/>
    /// Default Value: function
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionToolType value)
        {
            return value switch
            {
                FunctionToolType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionToolType? ToEnum(string value)
        {
            return value switch
            {
                "function" => FunctionToolType.Function,
                _ => null,
            };
        }
    }
}