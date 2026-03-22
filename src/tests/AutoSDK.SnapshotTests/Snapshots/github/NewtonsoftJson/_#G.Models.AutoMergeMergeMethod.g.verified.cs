//HintName: G.Models.AutoMergeMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AutoMergeMergeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="merge")]
        Merge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rebase")]
        Rebase,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="squash")]
        Squash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoMergeMergeMethod value)
        {
            return value switch
            {
                AutoMergeMergeMethod.Merge => "merge",
                AutoMergeMergeMethod.Rebase => "rebase",
                AutoMergeMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => AutoMergeMergeMethod.Merge,
                "rebase" => AutoMergeMergeMethod.Rebase,
                "squash" => AutoMergeMergeMethod.Squash,
                _ => null,
            };
        }
    }
}