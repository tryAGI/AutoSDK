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
        [global::System.Runtime.Serialization.EnumMember(Value="updated")]
        Updated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pushed")]
        Pushed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="full_name")]
        FullName,
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
                ReposListForUserSort.Updated => "updated",
                ReposListForUserSort.Pushed => "pushed",
                ReposListForUserSort.FullName => "full_name",
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
                "updated" => ReposListForUserSort.Updated,
                "pushed" => ReposListForUserSort.Pushed,
                "full_name" => ReposListForUserSort.FullName,
                _ => null,
            };
        }
    }
}