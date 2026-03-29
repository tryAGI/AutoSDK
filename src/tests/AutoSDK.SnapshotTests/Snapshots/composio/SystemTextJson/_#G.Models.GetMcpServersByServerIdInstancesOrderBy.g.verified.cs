//HintName: G.Models.GetMcpServersByServerIdInstancesOrderBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Field to use for ordering the results<br/>
    /// Default Value: updated_at<br/>
    /// Example: updated_at
    /// </summary>
    public enum GetMcpServersByServerIdInstancesOrderBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMcpServersByServerIdInstancesOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMcpServersByServerIdInstancesOrderBy value)
        {
            return value switch
            {
                GetMcpServersByServerIdInstancesOrderBy.CreatedAt => "created_at",
                GetMcpServersByServerIdInstancesOrderBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMcpServersByServerIdInstancesOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => GetMcpServersByServerIdInstancesOrderBy.CreatedAt,
                "updated_at" => GetMcpServersByServerIdInstancesOrderBy.UpdatedAt,
                _ => null,
            };
        }
    }
}