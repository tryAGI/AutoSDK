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
        [global::System.Runtime.Serialization.EnumMember(Value="uploaded")]
        Uploaded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processed")]
        Processed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    public static class OpenAIFileStatusExtensions
    {
        public static string ToValueString(this OpenAIFileStatus value)
        {
            return value switch
            {
                OpenAIFileStatus.Uploaded => "uploaded",
                OpenAIFileStatus.Processed => "processed",
                OpenAIFileStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static OpenAIFileStatus ToEnum(string value)
        {
            return value switch
            {
                "uploaded" => OpenAIFileStatus.Uploaded,
                "processed" => OpenAIFileStatus.Processed,
                "error" => OpenAIFileStatus.Error,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static OpenAIFileStatus ToEnum(int value)
        {
            return value switch
            {
                0 => OpenAIFileStatus.Uploaded,
                1 => OpenAIFileStatus.Processed,
                2 => OpenAIFileStatus.Error,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}