//HintName: G.Models.GetAllPromptTemplatesGetStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: active
    /// </summary>
    public enum GetAllPromptTemplatesGetStatus
    {
        /// <summary>
        /// 'active' (default) returns only active templates, 'deleted' returns only deleted/archived templates, 'all' returns both
        /// </summary>
        Active,
        /// <summary>
        /// 'active' (default) returns only active templates, 'deleted' returns only deleted/archived templates, 'all' returns both
        /// </summary>
        All,
        /// <summary>
        /// 'active' (default) returns only active templates, 'deleted' returns only deleted/archived templates, 'all' returns both
        /// </summary>
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllPromptTemplatesGetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllPromptTemplatesGetStatus value)
        {
            return value switch
            {
                GetAllPromptTemplatesGetStatus.Active => "active",
                GetAllPromptTemplatesGetStatus.All => "all",
                GetAllPromptTemplatesGetStatus.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllPromptTemplatesGetStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => GetAllPromptTemplatesGetStatus.Active,
                "all" => GetAllPromptTemplatesGetStatus.All,
                "deleted" => GetAllPromptTemplatesGetStatus.Deleted,
                _ => null,
            };
        }
    }
}