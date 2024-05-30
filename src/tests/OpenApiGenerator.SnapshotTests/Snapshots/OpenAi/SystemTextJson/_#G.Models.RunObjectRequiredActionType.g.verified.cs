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

    public static class RunObjectRequiredActionTypeExtensions
    {
        public static string ToValueString(this RunObjectRequiredActionType value)
        {
            return value switch
            {
                RunObjectRequiredActionType.SubmitToolOutputs => "submit_tool_outputs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunObjectRequiredActionType ToEnum(string value)
        {
            return value switch
            {
                "submit_tool_outputs" => RunObjectRequiredActionType.SubmitToolOutputs,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunObjectRequiredActionType ToEnum(int value)
        {
            return value switch
            {
                0 => RunObjectRequiredActionType.SubmitToolOutputs,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}