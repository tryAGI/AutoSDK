//HintName: G.Models.ClassroomAssignmentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether it's a group assignment or individual assignment.<br/>
    /// Example: individual
    /// </summary>
    public enum ClassroomAssignmentType
    {
        /// <summary>
        /// 
        /// </summary>
        Individual,
        /// <summary>
        /// 
        /// </summary>
        Group,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassroomAssignmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassroomAssignmentType value)
        {
            return value switch
            {
                ClassroomAssignmentType.Individual => "individual",
                ClassroomAssignmentType.Group => "group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassroomAssignmentType? ToEnum(string value)
        {
            return value switch
            {
                "individual" => ClassroomAssignmentType.Individual,
                "group" => ClassroomAssignmentType.Group,
                _ => null,
            };
        }
    }
}