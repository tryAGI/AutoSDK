//HintName: G.Models.SimpleClassroomAssignmentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether it's a Group Assignment or Individual Assignment.
    /// <br/>Example: individual
    /// </summary>
    public enum SimpleClassroomAssignmentType
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
    public static class SimpleClassroomAssignmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimpleClassroomAssignmentType value)
        {
            return value switch
            {
                SimpleClassroomAssignmentType.Individual => "individual",
                SimpleClassroomAssignmentType.Group => "group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimpleClassroomAssignmentType ToEnum(string value)
        {
            return value switch
            {
                "individual" => SimpleClassroomAssignmentType.Individual,
                "group" => SimpleClassroomAssignmentType.Group,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}