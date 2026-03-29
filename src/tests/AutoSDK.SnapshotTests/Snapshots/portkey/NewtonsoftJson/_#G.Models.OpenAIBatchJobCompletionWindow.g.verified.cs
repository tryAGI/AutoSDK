//HintName: G.Models.OpenAIBatchJobCompletionWindow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Completion window for the batch job, `immediate` is only supported with Portkey Managed Batching.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIBatchJobCompletionWindow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="24h")]
        x24h,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="immediate")]
        Immediate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIBatchJobCompletionWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIBatchJobCompletionWindow value)
        {
            return value switch
            {
                OpenAIBatchJobCompletionWindow.x24h => "24h",
                OpenAIBatchJobCompletionWindow.Immediate => "immediate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIBatchJobCompletionWindow? ToEnum(string value)
        {
            return value switch
            {
                "24h" => OpenAIBatchJobCompletionWindow.x24h,
                "immediate" => OpenAIBatchJobCompletionWindow.Immediate,
                _ => null,
            };
        }
    }
}