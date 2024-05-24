//HintName: G.Models.CommitComparisonStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: ahead
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CommitComparisonStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="diverged")]
        Diverged,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ahead")]
        Ahead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="behind")]
        Behind,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="identical")]
        Identical,
    }
}