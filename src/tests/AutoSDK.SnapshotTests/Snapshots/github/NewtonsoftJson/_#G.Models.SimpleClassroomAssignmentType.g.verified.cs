//HintName: G.Models.SimpleClassroomAssignmentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether it's a Group Assignment or Individual Assignment.<br/>
    /// Example: individual
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SimpleClassroomAssignmentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="group")]
        Group,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="individual")]
        Individual,
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
                SimpleClassroomAssignmentType.Group => "group",
                SimpleClassroomAssignmentType.Individual => "individual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimpleClassroomAssignmentType? ToEnum(string value)
        {
            return value switch
            {
                "group" => SimpleClassroomAssignmentType.Group,
                "individual" => SimpleClassroomAssignmentType.Individual,
                _ => null,
            };
        }
    }
}