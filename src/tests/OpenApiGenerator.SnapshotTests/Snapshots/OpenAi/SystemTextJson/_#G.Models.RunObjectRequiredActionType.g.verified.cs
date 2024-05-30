//HintName: G.Models.RunObjectRequiredActionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// For now, this is always `submit_tool_outputs`.
    /// </summary>
    public enum RunObjectRequiredActionType
    {
        /// <summary>
        /// 
        /// </summary>
        SubmitToolOutputs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunObjectRequiredActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunObjectRequiredActionType value)
        {
            return value switch
            {
                RunObjectRequiredActionType.SubmitToolOutputs => "submit_tool_outputs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunObjectRequiredActionType ToEnum(string value)
        {
            return value switch
            {
                "submit_tool_outputs" => RunObjectRequiredActionType.SubmitToolOutputs,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}