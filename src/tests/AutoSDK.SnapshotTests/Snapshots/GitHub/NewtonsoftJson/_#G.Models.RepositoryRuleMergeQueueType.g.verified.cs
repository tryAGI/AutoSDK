//HintName: G.Models.RepositoryRuleMergeQueueType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleMergeQueueType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="merge_queue")]
        MergeQueue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleMergeQueueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleMergeQueueType value)
        {
            return value switch
            {
                RepositoryRuleMergeQueueType.MergeQueue => "merge_queue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleMergeQueueType? ToEnum(string value)
        {
            return value switch
            {
                "merge_queue" => RepositoryRuleMergeQueueType.MergeQueue,
                _ => null,
            };
        }
    }
}