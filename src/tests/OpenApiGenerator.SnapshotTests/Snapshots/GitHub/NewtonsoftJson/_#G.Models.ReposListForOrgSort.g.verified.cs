//HintName: G.Models.ReposListForOrgSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: created
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposListForOrgSort
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
    public static class ReposListForOrgSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListForOrgSort value)
        {
            return value switch
            {
                ReposListForOrgSort.Created => "created",
                ReposListForOrgSort.Updated => "updated",
                ReposListForOrgSort.Pushed => "pushed",
                ReposListForOrgSort.FullName => "full_name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListForOrgSort ToEnum(string value)
        {
            return value switch
            {
                "created" => ReposListForOrgSort.Created,
                "updated" => ReposListForOrgSort.Updated,
                "pushed" => ReposListForOrgSort.Pushed,
                "full_name" => ReposListForOrgSort.FullName,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}