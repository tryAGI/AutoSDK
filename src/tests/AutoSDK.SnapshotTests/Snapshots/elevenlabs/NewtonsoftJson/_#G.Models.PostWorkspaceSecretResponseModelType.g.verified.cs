//HintName: G.Models.PostWorkspaceSecretResponseModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostWorkspaceSecretResponseModelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stored")]
        Stored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostWorkspaceSecretResponseModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostWorkspaceSecretResponseModelType value)
        {
            return value switch
            {
                PostWorkspaceSecretResponseModelType.Stored => "stored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostWorkspaceSecretResponseModelType? ToEnum(string value)
        {
            return value switch
            {
                "stored" => PostWorkspaceSecretResponseModelType.Stored,
                _ => null,
            };
        }
    }
}