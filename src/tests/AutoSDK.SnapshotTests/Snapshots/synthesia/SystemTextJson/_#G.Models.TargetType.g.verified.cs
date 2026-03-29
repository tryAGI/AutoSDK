//HintName: G.Models.TargetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Types of entities that can be acted upon.<br/>
    /// WORKSPACE: A workspace entity<br/>
    /// VIDEO: A video entity<br/>
    /// USER: A user entity (can be same as Actor in self-service actions like login/profile updates)<br/>
    /// ORGANIZATION: An organization entity<br/>
    /// ASSET: An asset entity (avatars, images, etc.)<br/>
    /// LEARNER_GROUP: An LMS learner group (cohort) entity
    /// </summary>
    public enum TargetType
    {
        /// <summary>
        /// An asset entity (avatars, images, etc.)
        /// </summary>
        Asset,
        /// <summary>
        /// 
        /// </summary>
        LearnerGroup,
        /// <summary>
        /// An organization entity
        /// </summary>
        Organization,
        /// <summary>
        /// A user entity (can be same as Actor in self-service actions like login/profile updates)
        /// </summary>
        User,
        /// <summary>
        /// A video entity
        /// </summary>
        Video,
        /// <summary>
        /// A workspace entity
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TargetType value)
        {
            return value switch
            {
                TargetType.Asset => "asset",
                TargetType.LearnerGroup => "learner_group",
                TargetType.Organization => "organization",
                TargetType.User => "user",
                TargetType.Video => "video",
                TargetType.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TargetType? ToEnum(string value)
        {
            return value switch
            {
                "asset" => TargetType.Asset,
                "learner_group" => TargetType.LearnerGroup,
                "organization" => TargetType.Organization,
                "user" => TargetType.User,
                "video" => TargetType.Video,
                "workspace" => TargetType.Workspace,
                _ => null,
            };
        }
    }
}