//HintName: G.Models.CreateTalkResponseDtoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the talk
    /// </summary>
    public enum CreateTalkResponseDtoStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTalkResponseDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkResponseDtoStatus value)
        {
            return value switch
            {
                CreateTalkResponseDtoStatus.Created => "created",
                CreateTalkResponseDtoStatus.Done => "done",
                CreateTalkResponseDtoStatus.Error => "error",
                CreateTalkResponseDtoStatus.Rejected => "rejected",
                CreateTalkResponseDtoStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkResponseDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => CreateTalkResponseDtoStatus.Created,
                "done" => CreateTalkResponseDtoStatus.Done,
                "error" => CreateTalkResponseDtoStatus.Error,
                "rejected" => CreateTalkResponseDtoStatus.Rejected,
                "started" => CreateTalkResponseDtoStatus.Started,
                _ => null,
            };
        }
    }
}