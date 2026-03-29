//HintName: G.Models.GetResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the avatar
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetResponseStatus
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
        [global::System.Runtime.Serialization.EnumMember(Value="draft")]
        Draft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rejected")]
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="started")]
        Started,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="training-started")]
        TrainingStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="validating")]
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseStatus value)
        {
            return value switch
            {
                GetResponseStatus.Created => "created",
                GetResponseStatus.Done => "done",
                GetResponseStatus.Draft => "draft",
                GetResponseStatus.Error => "error",
                GetResponseStatus.Rejected => "rejected",
                GetResponseStatus.Started => "started",
                GetResponseStatus.TrainingStarted => "training-started",
                GetResponseStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetResponseStatus.Created,
                "done" => GetResponseStatus.Done,
                "draft" => GetResponseStatus.Draft,
                "error" => GetResponseStatus.Error,
                "rejected" => GetResponseStatus.Rejected,
                "started" => GetResponseStatus.Started,
                "training-started" => GetResponseStatus.TrainingStarted,
                "validating" => GetResponseStatus.Validating,
                _ => null,
            };
        }
    }
}