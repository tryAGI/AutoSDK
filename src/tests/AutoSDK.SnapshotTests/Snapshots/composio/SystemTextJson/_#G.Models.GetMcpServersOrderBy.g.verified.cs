//HintName: G.Models.GetMcpServersOrderBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Field to use for ordering the results<br/>
    /// Default Value: updated_at<br/>
    /// Example: updated_at
    /// </summary>
    public enum GetMcpServersOrderBy
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
    public static class GetMcpServersOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMcpServersOrderBy value)
        {
            return value switch
            {
                GetMcpServersOrderBy.CreatedAt => "created_at",
                GetMcpServersOrderBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMcpServersOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => GetMcpServersOrderBy.CreatedAt,
                "updated_at" => GetMcpServersOrderBy.UpdatedAt,
                _ => null,
            };
        }
    }
}