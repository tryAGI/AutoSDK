//HintName: G.Models.GenerationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GenerationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="complete")]
        Complete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="finalizing")]
        Finalizing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationStatus value)
        {
            return value switch
            {
                GenerationStatus.Complete => "complete",
                GenerationStatus.Error => "error",
                GenerationStatus.Finalizing => "finalizing",
                GenerationStatus.Processing => "processing",
                GenerationStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => GenerationStatus.Complete,
                "error" => GenerationStatus.Error,
                "finalizing" => GenerationStatus.Finalizing,
                "processing" => GenerationStatus.Processing,
                "queued" => GenerationStatus.Queued,
                _ => null,
            };
        }
    }
}