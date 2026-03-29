//HintName: G.Models.GetVideoTranslationsApiResponseTranslationDiscriminatorStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetVideoTranslationsApiResponseTranslationDiscriminatorStatus
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
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetVideoTranslationsApiResponseTranslationDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideoTranslationsApiResponseTranslationDiscriminatorStatus value)
        {
            return value switch
            {
                GetVideoTranslationsApiResponseTranslationDiscriminatorStatus.Complete => "complete",
                GetVideoTranslationsApiResponseTranslationDiscriminatorStatus.Error => "error",
                GetVideoTranslationsApiResponseTranslationDiscriminatorStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideoTranslationsApiResponseTranslationDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => GetVideoTranslationsApiResponseTranslationDiscriminatorStatus.Complete,
                "error" => GetVideoTranslationsApiResponseTranslationDiscriminatorStatus.Error,
                "in_progress" => GetVideoTranslationsApiResponseTranslationDiscriminatorStatus.InProgress,
                _ => null,
            };
        }
    }
}