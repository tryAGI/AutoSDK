//HintName: G.Models.GetResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the avatar
    /// </summary>
    public enum GetResponseStatus2
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
        Draft,
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
        /// <summary>
        /// 
        /// </summary>
        TrainingStarted,
        /// <summary>
        /// 
        /// </summary>
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseStatus2 value)
        {
            return value switch
            {
                GetResponseStatus2.Created => "created",
                GetResponseStatus2.Done => "done",
                GetResponseStatus2.Draft => "draft",
                GetResponseStatus2.Error => "error",
                GetResponseStatus2.Rejected => "rejected",
                GetResponseStatus2.Started => "started",
                GetResponseStatus2.TrainingStarted => "training-started",
                GetResponseStatus2.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "created" => GetResponseStatus2.Created,
                "done" => GetResponseStatus2.Done,
                "draft" => GetResponseStatus2.Draft,
                "error" => GetResponseStatus2.Error,
                "rejected" => GetResponseStatus2.Rejected,
                "started" => GetResponseStatus2.Started,
                "training-started" => GetResponseStatus2.TrainingStarted,
                "validating" => GetResponseStatus2.Validating,
                _ => null,
            };
        }
    }
}