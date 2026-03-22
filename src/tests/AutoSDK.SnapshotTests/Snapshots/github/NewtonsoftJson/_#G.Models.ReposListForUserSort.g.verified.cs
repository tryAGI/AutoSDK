//HintName: G.Models.ReposListForUserSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: full_name
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposListForUserSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="full_name")]
        FullName,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pushed")]
        Pushed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated")]
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListForUserSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListForUserSort value)
        {
            return value switch
            {
                ReposListForUserSort.Created => "created",
                ReposListForUserSort.FullName => "full_name",
                ReposListForUserSort.Pushed => "pushed",
                ReposListForUserSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListForUserSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => ReposListForUserSort.Created,
                "full_name" => ReposListForUserSort.FullName,
                "pushed" => ReposListForUserSort.Pushed,
                "updated" => ReposListForUserSort.Updated,
                _ => null,
            };
        }
    }
}