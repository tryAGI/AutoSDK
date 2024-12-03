//HintName: G.Models.ProjectApiKeyListResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectApiKeyListResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectApiKeyListResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectApiKeyListResponseObject value)
        {
            return value switch
            {
                ProjectApiKeyListResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectApiKeyListResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ProjectApiKeyListResponseObject.List,
                _ => null,
            };
        }
    }
}