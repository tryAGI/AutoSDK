//HintName: G.Models.OpenAIFileStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated. The current status of the file, which can be either `uploaded`, `processed`, or `error`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIFileStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processed")]
        Processed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uploaded")]
        Uploaded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIFileStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIFileStatus value)
        {
            return value switch
            {
                OpenAIFileStatus.Error => "error",
                OpenAIFileStatus.Processed => "processed",
                OpenAIFileStatus.Uploaded => "uploaded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIFileStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => OpenAIFileStatus.Error,
                "processed" => OpenAIFileStatus.Processed,
                "uploaded" => OpenAIFileStatus.Uploaded,
                _ => null,
            };
        }
    }
}