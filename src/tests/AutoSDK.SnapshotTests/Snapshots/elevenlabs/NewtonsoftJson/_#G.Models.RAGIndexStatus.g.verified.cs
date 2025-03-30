//HintName: G.Models.RAGIndexStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RAGIndexStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="succeeded")]
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RAGIndexStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RAGIndexStatus value)
        {
            return value switch
            {
                RAGIndexStatus.Created => "created",
                RAGIndexStatus.Processing => "processing",
                RAGIndexStatus.Failed => "failed",
                RAGIndexStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RAGIndexStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => RAGIndexStatus.Created,
                "processing" => RAGIndexStatus.Processing,
                "failed" => RAGIndexStatus.Failed,
                "succeeded" => RAGIndexStatus.Succeeded,
                _ => null,
            };
        }
    }
}