//HintName: G.Models.PostWorkspaceSecretRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostWorkspaceSecretRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        New,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostWorkspaceSecretRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostWorkspaceSecretRequestType value)
        {
            return value switch
            {
                PostWorkspaceSecretRequestType.New => "new",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostWorkspaceSecretRequestType? ToEnum(string value)
        {
            return value switch
            {
                "new" => PostWorkspaceSecretRequestType.New,
                _ => null,
            };
        }
    }
}