//HintName: G.Models.Create1ResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the avatar
    /// </summary>
    public enum Create1ResponseStatus
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
    public static class Create1ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create1ResponseStatus value)
        {
            return value switch
            {
                Create1ResponseStatus.Created => "created",
                Create1ResponseStatus.Done => "done",
                Create1ResponseStatus.Draft => "draft",
                Create1ResponseStatus.Error => "error",
                Create1ResponseStatus.Rejected => "rejected",
                Create1ResponseStatus.Started => "started",
                Create1ResponseStatus.TrainingStarted => "training-started",
                Create1ResponseStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create1ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => Create1ResponseStatus.Created,
                "done" => Create1ResponseStatus.Done,
                "draft" => Create1ResponseStatus.Draft,
                "error" => Create1ResponseStatus.Error,
                "rejected" => Create1ResponseStatus.Rejected,
                "started" => Create1ResponseStatus.Started,
                "training-started" => Create1ResponseStatus.TrainingStarted,
                "validating" => Create1ResponseStatus.Validating,
                _ => null,
            };
        }
    }
}