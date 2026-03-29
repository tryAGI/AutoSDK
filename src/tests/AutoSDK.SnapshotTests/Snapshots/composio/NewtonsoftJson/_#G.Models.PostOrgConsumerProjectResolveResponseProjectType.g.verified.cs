//HintName: G.Models.PostOrgConsumerProjectResolveResponseProjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Resolved project type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostOrgConsumerProjectResolveResponseProjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONSUMER")]
        Consumer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostOrgConsumerProjectResolveResponseProjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostOrgConsumerProjectResolveResponseProjectType value)
        {
            return value switch
            {
                PostOrgConsumerProjectResolveResponseProjectType.Consumer => "CONSUMER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostOrgConsumerProjectResolveResponseProjectType? ToEnum(string value)
        {
            return value switch
            {
                "CONSUMER" => PostOrgConsumerProjectResolveResponseProjectType.Consumer,
                _ => null,
            };
        }
    }
}