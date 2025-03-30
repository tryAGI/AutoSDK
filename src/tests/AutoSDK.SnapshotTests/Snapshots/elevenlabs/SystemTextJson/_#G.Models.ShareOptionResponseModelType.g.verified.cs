//HintName: G.Models.ShareOptionResponseModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the principal: user, group, or workspace api key.
    /// </summary>
    public enum ShareOptionResponseModelType
    {
        /// <summary>
        /// user, group, or workspace api key.
        /// </summary>
        User,
        /// <summary>
        /// user, group, or workspace api key.
        /// </summary>
        Group,
        /// <summary>
        /// user, group, or workspace api key.
        /// </summary>
        Key,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShareOptionResponseModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShareOptionResponseModelType value)
        {
            return value switch
            {
                ShareOptionResponseModelType.User => "user",
                ShareOptionResponseModelType.Group => "group",
                ShareOptionResponseModelType.Key => "key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShareOptionResponseModelType? ToEnum(string value)
        {
            return value switch
            {
                "user" => ShareOptionResponseModelType.User,
                "group" => ShareOptionResponseModelType.Group,
                "key" => ShareOptionResponseModelType.Key,
                _ => null,
            };
        }
    }
}