//HintName: G.Models.Create2ResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the scene
    /// </summary>
    public enum Create2ResponseStatus
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
    public static class Create2ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create2ResponseStatus value)
        {
            return value switch
            {
                Create2ResponseStatus.Created => "created",
                Create2ResponseStatus.Done => "done",
                Create2ResponseStatus.Error => "error",
                Create2ResponseStatus.Rejected => "rejected",
                Create2ResponseStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create2ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => Create2ResponseStatus.Created,
                "done" => Create2ResponseStatus.Done,
                "error" => Create2ResponseStatus.Error,
                "rejected" => Create2ResponseStatus.Rejected,
                "started" => Create2ResponseStatus.Started,
                _ => null,
            };
        }
    }
}