//HintName: G.Models.GroupStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GroupStatus
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
        PartialDone,
        /// <summary>
        /// 
        /// </summary>
        Validating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupStatus value)
        {
            return value switch
            {
                GroupStatus.Created => "created",
                GroupStatus.Done => "done",
                GroupStatus.Error => "error",
                GroupStatus.PartialDone => "partial-done",
                GroupStatus.Validating => "validating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupStatus? ToEnum(string value)
        {
            return value switch
            {
                "created" => GroupStatus.Created,
                "done" => GroupStatus.Done,
                "error" => GroupStatus.Error,
                "partial-done" => GroupStatus.PartialDone,
                "validating" => GroupStatus.Validating,
                _ => null,
            };
        }
    }
}