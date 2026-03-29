//HintName: G.Models.GetLLMsTxtStatusResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetLLMsTxtStatusResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetLLMsTxtStatusResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetLLMsTxtStatusResponseStatus value)
        {
            return value switch
            {
                GetLLMsTxtStatusResponseStatus.Completed => "completed",
                GetLLMsTxtStatusResponseStatus.Failed => "failed",
                GetLLMsTxtStatusResponseStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetLLMsTxtStatusResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetLLMsTxtStatusResponseStatus.Completed,
                "failed" => GetLLMsTxtStatusResponseStatus.Failed,
                "processing" => GetLLMsTxtStatusResponseStatus.Processing,
                _ => null,
            };
        }
    }
}