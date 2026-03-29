//HintName: G.Models.ListSecretReferencesResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListSecretReferencesResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListSecretReferencesResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSecretReferencesResponseObject value)
        {
            return value switch
            {
                ListSecretReferencesResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSecretReferencesResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ListSecretReferencesResponseObject.List,
                _ => null,
            };
        }
    }
}