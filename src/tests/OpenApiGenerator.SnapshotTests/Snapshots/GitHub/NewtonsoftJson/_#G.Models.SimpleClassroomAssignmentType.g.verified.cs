//HintName: G.Models.SimpleClassroomAssignmentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether it's a Group Assignment or Individual Assignment.
    /// <br/>Example: individual
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SimpleClassroomAssignmentType
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