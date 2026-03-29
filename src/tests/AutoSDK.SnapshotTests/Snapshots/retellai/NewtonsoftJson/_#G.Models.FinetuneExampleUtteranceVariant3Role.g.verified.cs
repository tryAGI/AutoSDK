//HintName: G.Models.FinetuneExampleUtteranceVariant3Role.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FinetuneExampleUtteranceVariant3Role
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_call_result")]
        ToolCallResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinetuneExampleUtteranceVariant3RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinetuneExampleUtteranceVariant3Role value)
        {
            return value switch
            {
                FinetuneExampleUtteranceVariant3Role.ToolCallResult => "tool_call_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinetuneExampleUtteranceVariant3Role? ToEnum(string value)
        {
            return value switch
            {
                "tool_call_result" => FinetuneExampleUtteranceVariant3Role.ToolCallResult,
                _ => null,
            };
        }
    }
}