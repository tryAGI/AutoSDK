//HintName: G.Models.NotificationConfigMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The method to be used with http and https urls. The default is post.
    /// </summary>
    public enum NotificationConfigMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NotificationConfigMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotificationConfigMethod value)
        {
            return value switch
            {
                NotificationConfigMethod.Post => "post",
                NotificationConfigMethod.Put => "put",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotificationConfigMethod? ToEnum(string value)
        {
            return value switch
            {
                "post" => NotificationConfigMethod.Post,
                "put" => NotificationConfigMethod.Put,
                _ => null,
            };
        }
    }
}