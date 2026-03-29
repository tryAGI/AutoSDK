//HintName: G.Models.CampaignControllerFindAllSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CampaignControllerFindAllSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASC")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DESC")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CampaignControllerFindAllSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignControllerFindAllSortOrder value)
        {
            return value switch
            {
                CampaignControllerFindAllSortOrder.Asc => "ASC",
                CampaignControllerFindAllSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignControllerFindAllSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => CampaignControllerFindAllSortOrder.Asc,
                "DESC" => CampaignControllerFindAllSortOrder.Desc,
                _ => null,
            };
        }
    }
}