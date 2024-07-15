//HintName: G.Models.IssuesLockRequestLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason for locking the issue or pull request conversation. Lock will fail if you don't use one of these reasons:  <br/>
    ///  * `off-topic`  <br/>
    ///  * `too heated`  <br/>
    ///  * `resolved`  <br/>
    ///  * `spam`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssuesLockRequestLockReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off-topic")]
        OffTopic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="too heated")]
        TooHeated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resolved")]
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spam")]
        Spam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesLockRequestLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesLockRequestLockReason value)
        {
            return value switch
            {
                IssuesLockRequestLockReason.OffTopic => "off-topic",
                IssuesLockRequestLockReason.TooHeated => "too heated",
                IssuesLockRequestLockReason.Resolved => "resolved",
                IssuesLockRequestLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesLockRequestLockReason? ToEnum(string value)
        {
            return value switch
            {
                "off-topic" => IssuesLockRequestLockReason.OffTopic,
                "too heated" => IssuesLockRequestLockReason.TooHeated,
                "resolved" => IssuesLockRequestLockReason.Resolved,
                "spam" => IssuesLockRequestLockReason.Spam,
                _ => null,
            };
        }
    }
}