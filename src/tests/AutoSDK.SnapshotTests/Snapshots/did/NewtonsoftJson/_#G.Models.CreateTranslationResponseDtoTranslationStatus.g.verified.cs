//HintName: G.Models.CreateTranslationResponseDtoTranslationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the translation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTranslationResponseDtoTranslationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ready")]
        Ready,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rejected")]
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validating")]
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTranslationResponseDtoTranslationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranslationResponseDtoTranslationStatus value)
        {
            return value switch
            {
                CreateTranslationResponseDtoTranslationStatus.Created => "created",
                CreateTranslationResponseDtoTranslationStatus.Done => "done",
                CreateTranslationResponseDtoTranslationStatus.Error => "error",
                CreateTranslationResponseDtoTranslationStatus.Ready => "ready",
                CreateTranslationResponseDtoTranslationStatus.Rejected => "rejected",
                CreateTranslationResponseDtoTranslationStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranslationResponseDtoTranslationStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => CreateTranslationResponseDtoTranslationStatus.Created,
                "done" => CreateTranslationResponseDtoTranslationStatus.Done,
                "error" => CreateTranslationResponseDtoTranslationStatus.Error,
                "ready" => CreateTranslationResponseDtoTranslationStatus.Ready,
                "rejected" => CreateTranslationResponseDtoTranslationStatus.Rejected,
                "validating" => CreateTranslationResponseDtoTranslationStatus.Validating,
                _ => null,
            };
        }
    }
}