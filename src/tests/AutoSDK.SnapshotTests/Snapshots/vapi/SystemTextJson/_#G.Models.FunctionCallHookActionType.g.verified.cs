//HintName: G.Models.FunctionCallHookActionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "function" for Function tool.
    /// </summary>
    public enum FunctionCallHookActionType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionCallHookActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallHookActionType value)
        {
            return value switch
            {
                FunctionCallHookActionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallHookActionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => FunctionCallHookActionType.Function,
                _ => null,
            };
        }
    }
}