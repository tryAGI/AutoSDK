//HintName: G.Models.ReposCreateCommitStatusRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the status.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposCreateCommitStatusRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposCreateCommitStatusRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateCommitStatusRequestState value)
        {
            return value switch
            {
                ReposCreateCommitStatusRequestState.Error => "error",
                ReposCreateCommitStatusRequestState.Failure => "failure",
                ReposCreateCommitStatusRequestState.Pending => "pending",
                ReposCreateCommitStatusRequestState.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateCommitStatusRequestState? ToEnum(string value)
        {
            return value switch
            {
                "error" => ReposCreateCommitStatusRequestState.Error,
                "failure" => ReposCreateCommitStatusRequestState.Failure,
                "pending" => ReposCreateCommitStatusRequestState.Pending,
                "success" => ReposCreateCommitStatusRequestState.Success,
                _ => null,
            };
        }
    }
}