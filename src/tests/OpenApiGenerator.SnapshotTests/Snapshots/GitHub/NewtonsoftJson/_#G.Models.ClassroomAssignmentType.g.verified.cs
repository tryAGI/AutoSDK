//HintName: G.Models.ClassroomAssignmentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether it's a group assignment or individual assignment.
    /// <br/>Example: individual
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClassroomAssignmentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="individual")]
        Individual,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="group")]
        Group,
    }
}