//HintName: G.Models.FinetuneExampleUtteranceVariant2Role.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinetuneExampleUtteranceVariant2Role
    {
        /// <summary>
        /// 
        /// </summary>
        ToolCallInvocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneExampleUtteranceVariant2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneExampleUtteranceVariant2Role value)
        {
            return value switch
            {
                FinetuneExampleUtteranceVariant2Role.ToolCallInvocation => "tool_call_invocation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneExampleUtteranceVariant2Role? ToEnum(string value)
        {
            return value switch
            {
                "tool_call_invocation" => FinetuneExampleUtteranceVariant2Role.ToolCallInvocation,
                _ => null,
            };
        }
    }
}