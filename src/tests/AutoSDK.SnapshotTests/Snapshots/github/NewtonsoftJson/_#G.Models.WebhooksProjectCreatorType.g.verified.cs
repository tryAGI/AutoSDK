﻿//HintName: G.Models.WebhooksProjectCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksProjectCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksProjectCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksProjectCreatorType value)
        {
            return value switch
            {
                WebhooksProjectCreatorType.Bot => "Bot",
                WebhooksProjectCreatorType.User => "User",
                WebhooksProjectCreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksProjectCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksProjectCreatorType.Bot,
                "User" => WebhooksProjectCreatorType.User,
                "Organization" => WebhooksProjectCreatorType.Organization,
                _ => null,
            };
        }
    }
}